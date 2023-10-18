using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator;

class RadioStation
{
    private float _frequency;

    public RadioStation(float frequency)
    {
        _frequency = frequency;
    }

    public float GetFrequency()
    {
        return _frequency;
    }
}

class StationList : IEnumerable<RadioStation>
{
    List<RadioStation> _radioStations = new();

    public RadioStation this[int index]
    {
        get
        {
            return _radioStations[index];
        }
        set
        {
            _radioStations.Insert(index, value);
        }
    }

    public void Add(RadioStation station)
    {
        _radioStations.Add(station);
    }

    public void Remove(RadioStation station)
    {
        _radioStations.Remove(station);
    }

    public IEnumerator<RadioStation> GetEnumerator()
    {
        return this.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        // Use can switch to this internal collection if you do not want to transform
        // return _radioStations.GetEnumerator();

        // Use this if you want to transform the object before rendering
        foreach (var x in _radioStations)
        {
            yield return x;
        }
    }
}