using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer;

class JobPost
{
    public string Title { get; private set; }
    public JobPost(string title)
    {
        Title = title;
    }
}

class JobSeeker : IObserver<JobPost>
{
    public string Name { get; private set; }

    public JobSeeker(string name)
    {
        Name = name;
    }

    //Method not being  called by JobPosting class currently
    public void OnCompleted()
    {
        //No implementation
    }

    //Method not being  called by JobPosting class currently
    public void OnError(Exception error)
    {
        //No implementation
    }

    public void OnNext(JobPost value)
    {
        Console.WriteLine($"Hi {Name}! New job posted: {value.Title}");
    }
}

class JobPostings : IObservable<JobPost>
{
    private List<IObserver<JobPost>> _observers;
    private List<JobPost> _jobPostings;

    public JobPostings()
    {
        _jobPostings = new();
        _observers = new();
    }

    public IDisposable Subscribe(IObserver<JobPost> observer)
    {
        // Check whether observer is already registered. If not, add it.
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
        return new Unsubscriber<JobPost>(_observers, observer);
    }

    private void Notify(JobPost jobPost)
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(jobPost);
        }
    }

    public void AddJob(JobPost jobPost)
    {
        _jobPostings.Add(jobPost);
        Notify(jobPost);
    }
}

internal class Unsubscriber<T> : IDisposable
{
    private List<IObserver<T>> _observers;
    private IObserver<T> _observer;

    public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
    {
        _observers = observers;
        _observer = observer;
    }

    public void Dispose()
    {
        if (_observers.Contains(_observer))
        {
            _observers.Remove(_observer);
        }
    }
}