using System.Text;
using System.Data;

namespace Metodos_Numericos.Models
{
    public class Metodos
    {
        public string equation { get; set; }
        public float xi {get; set; }
        public float xs { get; set; }
        public float h { get; set; }
        
        public Metodos(string equation, float xi, float xs, float h)
        {
            this.equation = equation;
            this.xi = xi;
            this.xs = xs;
            this.h = h;
        }
        public List<List<float>> iteaciones_sucesivas()
        {
            return 0;
        }

        public List<List<float>> regla_falsa()
        {
            return 0;
        }

        public List<List<float>> biseccion()
        {
            List<float> attributes = new List<float>();
            List<List<float> data = new List<List<float>>();

            StringBuilder fxi = new StringBuilder();
            float fxiR;

            StringBuilder fxs = new StringBuilder();
            float fxsR;

            StringBuilder fxr = new StringBuilder();
            float xr = (this.xi + this.xs) / 2;

            for (int i = 0; i < 20; i++)
            {
                attributes.Clear();
                foreach (var s in this.equation)
                {
                    if (s == 'x')
                    {
                        fxi.Append(this.xi.ToString());
                        fxs.Append(this.xs.ToString());
                        
                    }
                    else
                    {
                        fxi.Append(s);
                        fxs.Append(s);
                    }
                }
                var fxiR = new DataTable().Compute(fxi.ToString(), null);
                var fxrR = new DataTable().Compute(fxr.ToString(), null);

                attributes.Append(i);
                attributes.Append(this.xi);
                attributes.Append(this.xs);
                attributes.Append(xr);
                attributes.Append(fxiR);
                attributes.Append(fxrR);


                if (fxiR * fxrR < 0)
                    this.xs = xr;
                else if (fxiR * fxrR > 0)
                    this.xi = xr;
                else if (fxiR * fxrR) == 0)
                {
                    this.xs = xr;
                    thi. xi = xr;
                }
                data.Append(attributes);
            }
            return data;
        }

        public List<List<float>> punto_fijo()
        {
            return 0;
        }
    }
}