using System;

namespace Tipos_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            

            sbyte byteConSigno = sbyte.MaxValue;
            byte byteSinSigno = byte.MaxValue;
            short shortConSigno = short.MaxValue;
            ushort shortSinSigno = ushort.MaxValue;
            int intConSigno = int.MaxValue;
            uint intSinSigno = uint.MaxValue;
            long longConSigno = long.MaxValue;
            ulong longSinSigno = ulong.MaxValue;
            float floatValor = float.MaxValue;
            double doubleValor = double.MaxValue;
            decimal decimalValor = decimal.MaxValue;

             Console.WriteLine ("MAX[sbyte]: {0}", byteConSigno);
             Console.WriteLine ("MAX[byte]: {0}", byteSinSigno);
             Console.WriteLine ("MAX[short]: {0}", shortConSigno);
             Console.WriteLine ("MAX[ushort]: {0}", shortSinSigno);
             Console.WriteLine ("MAX[int]: {0}", intConSigno);
             Console.WriteLine ("MAX[uint]: {0}", intSinSigno);
             Console.WriteLine ("MAX[long]: {0}", longConSigno);
             Console.WriteLine ("MAX[ulong]: {0}", longSinSigno);
             Console.WriteLine ("MAX[float]: {0}", floatValor);
             Console.WriteLine ("MAX[double]: {0}", doubleValor);
             Console.WriteLine ("MAX[decimal]: {0}", decimalValor);

             
        }
    }
}
