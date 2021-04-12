using System;

namespace Práctica1
{
    public class Operaciones
    {
        public string operacion(int dat1, int dat2, string op)
        {
            switch (op)
            {
                case "+":
                    int suma = dat1 + dat2;
                    return suma + "";

                case "-":
                    int resta = dat1 - dat2;
                    return resta + "";

                case "/":
                    if (dat1 > 0 && dat2 > 0)
                    {
                        int divicion = dat1 / dat2;
                        return divicion + "";
                    }
                    else
                    {
                        return "Imposile división entre 0";
                    }

                case "*":
                    int multiplicacion = dat1 * dat2;
                    return multiplicacion + "";

                case "^":
                    if (dat2 != 0)
                    {
                        double elevar = Math.Pow(dat1, dat2);
                        return elevar + "";
                    }
                    break;

            }

            return null;
        }

    }
}
