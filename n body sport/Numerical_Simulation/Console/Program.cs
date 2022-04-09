using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N_body_sport;

namespace Console {
  class Program {
    static void Main(string[] args) {
      CelestialBody[] cbody = new CelestialBody[3];
      for (int i = 0; i < cbody.Length; i++) {
        cbody[i] = new CelestialBody();
      }
      double G = Initialization.RandomIni(cbody);
      System.Console.WriteLine(G);
    }
  }
}
