using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendSample.Controllers
{
    public enum GameState
    {
        PLAYERONE,
        PLAYERTWO,
        TIE,
        RESUME
    };

    public class HomeController : Controller
    {
        private static String[] x = new String[9];

        public GameState GamePlay(int n, int t)
        {
            HttpContext.Response.AppendHeader("Access-Control-Allow-Origin", "*");
            HttpContext.Response.AppendHeader("Access-Control-Allow-Headers", "access-control-allow-origin,content-type");
            HttpContext.Response.AppendHeader("Access-Control-Allow-Methods", "GET");

            if (t % 2 == 0)
            {
                x[n] = "O";
            }
            else
            {
                x[n] = "X";
            }
            if 
              (
                (x[0] != null && x[0].Equals(x[1]) && x[1].Equals(x[2])  ) ||
                (x[3] != null && x[3].Equals(x[4]) && x[4].Equals(x[5]) ) ||
                (x[6] != null && x[6].Equals(x[7]) && x[7].Equals(x[8]) ) ||
                (x[0] != null && x[0].Equals(x[3]) && x[3].Equals(x[6]) ) ||
                (x[1] != null && x[1].Equals(x[4]) && x[4].Equals(x[7]) ) ||
                (x[2] != null && x[2].Equals(x[5]) && x[5].Equals(x[8]) ) ||
                (x[0] != null && x[0].Equals(x[4]) && x[4].Equals(x[8])) ||
                (x[2] != null && x[2].Equals(x[4]) && x[4].Equals(x[6]) )
               )
            {
                if(t%2 == 0)
                {
                    x = new String[9];
                    return GameState.PLAYERTWO;
                }
                else
                {
                    x = new String[9];
                    return GameState.PLAYERONE;
                }
            }
            if(t == 9)
            {
                x = new String[9];
                return GameState.TIE;
            }

            return GameState.RESUME;
        }
        public GameState GamePlay2(int n, int t)
        {
            HttpContext.Response.AppendHeader("Access-Control-Allow-Origin", "*");
            HttpContext.Response.AppendHeader("Access-Control-Allow-Headers", "access-control-allow-origin,content-type");
            HttpContext.Response.AppendHeader("Access-Control-Allow-Methods", "GET");
            var flag = false;
            if (t % 2 != 0)
            {
                flag = true;
                x[n] = "X";
            }
            if
              (
                (x[0] != null && x[0].Equals(x[1]) && x[1].Equals(x[2])) ||
                (x[3] != null && x[3].Equals(x[4]) && x[4].Equals(x[5])) ||
                (x[6] != null && x[6].Equals(x[7]) && x[7].Equals(x[8])) ||
                (x[0] != null && x[0].Equals(x[3]) && x[3].Equals(x[6])) ||
                (x[1] != null && x[1].Equals(x[4]) && x[4].Equals(x[7])) ||
                (x[2] != null && x[2].Equals(x[5]) && x[5].Equals(x[8])) ||
                (x[0] != null && x[0].Equals(x[4]) && x[4].Equals(x[8])) ||
                (x[2] != null && x[2].Equals(x[4]) && x[4].Equals(x[6]))
               )
            {
                if (!flag)
                {
                    x = new String[9];
                    return GameState.PLAYERTWO;
                }
                else
                {
                    x = new String[9];
                    return GameState.PLAYERONE;
                }
            }
            if (t == 9)
            {
                x = new String[9];
                return GameState.TIE;
            }

            return GameState.RESUME;
        }
        public int Where()
        {
            HttpContext.Response.AppendHeader("Access-Control-Allow-Origin", "*");
            HttpContext.Response.AppendHeader("Access-Control-Allow-Headers", "access-control-allow-origin,content-type");
            HttpContext.Response.AppendHeader("Access-Control-Allow-Methods", "GET");
            while (true)
            {
                Random rnd = new Random();
                int random = rnd.Next(0, 9);
                if (x[random] == null)
                {
                    x[random] = "O";
                    return random;
                }
            }
        }
    }
}
