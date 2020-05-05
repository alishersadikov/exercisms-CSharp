using System;

public class SpaceAge
{
  public int seconds;
  public SpaceAge(int seconds)
  {
    this.seconds = seconds;
  }

  public double OnEarth()
  // Earth: orbital period 365.25 Earth days, or 31557600 seconds
  {
    return (double)seconds / (365.25 * 24 * 60 * 60);
  }

  public double OnMercury()
  // Mercury: orbital period 0.2408467 Earth years
  {
    return OnEarth() / 0.2408467;
  }

  public double OnVenus()
  // Venus: orbital period 0.61519726 Earth years
  {
    return OnEarth() / 0.61519726;
  }

  public double OnMars()
  // Mars: orbital period 1.8808158 Earth years
  {
    return OnEarth() / 1.8808158;
  }

  public double OnJupiter()
  // Jupiter: orbital period 11.862615 Earth years
  {
    return OnEarth() / 11.862615;
  }

  public double OnSaturn()
  // Saturn: orbital period 29.447498 Earth years
  {
    return OnEarth() / 29.447498;
  }

  public double OnUranus()
  // Uranus: orbital period 84.016846 Earth years
  {
    return OnEarth() / 84.016846;
  }

  public double OnNeptune()
  // Neptune: orbital period 164.79132 Earth years
  {
    return OnEarth() / 164.79132;
  }
}