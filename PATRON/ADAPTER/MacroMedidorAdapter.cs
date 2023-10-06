namespace PATRON.ADAPTER
{
    public class MacroMedidorAdapter : Medidor
    {
        MacroMedidor macroMedidor = new MacroMedidor();

        public override void Lectura1()
        {
            macroMedidor.LecturaA();
        }

        public override void Lectura2()
        {
            macroMedidor.LecturaB();
        }

        public void Lectura3()
        {
            macroMedidor.LecturaC();
        }

        public void Lectura4()
        {
            macroMedidor.LecturaD();
        }

        public override void CalcularMecanico()
        {
            macroMedidor.CalcularTelemedida();
        }
    }
}