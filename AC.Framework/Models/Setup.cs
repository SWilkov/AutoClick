using System;
using System.Collections.Generic;
using System.Text;

namespace AC.Framework.Models
{
  public class Setup
  {
    public Time Interval { get; set; }
    public Time RunningTime { get; set; }
    public bool UseCurrentLocation { get; set; } = true;
    public Repeater Repeater { get; set; }
    public MouseLocation MouseLocation { get; set; }
    public Setup()
    {
      this.MouseLocation = new MouseLocation();
      this.Interval = new Time();
      this.RunningTime = new Time();
      this.Repeater = new Repeater();
    }
  }
}
