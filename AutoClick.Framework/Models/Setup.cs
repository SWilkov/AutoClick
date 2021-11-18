using System;
using System.Collections.Generic;
using System.Text;

namespace AutoClick.Framework.Models
{
  public class Setup
  {
    public double Hours { get; set; } = 0;
    public double Minutes { get; set; } = 0;
    public double Seconds { get; set; } = 0;
    public int Milliseconds { get; set; } = 0;
    public bool UseCurrentLocation { get; set; } = true;
    public int RepeatsFor { get; set; } = 0;
    public bool Repeats 
    { 
      get 
      { 
        return RepeatsFor > default(int);
      }
    }

    public MouseLocation MouseLocation { get; set; }
    public Setup()
    {
      this.MouseLocation = new MouseLocation();
    }
  }
}
