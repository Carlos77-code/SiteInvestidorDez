using SiteInvestidorDez.Core;

namespace SiteInvestidorDez.Page
{
    class ValidaAcaoPage : Begin
    {
        public void PreencheCampoAcao()
        {
            EscreveTexto("/html/body/div[3]/div/div/section[1]/div/div/div[1]/div/form/div/span/input[2]", "MXRF11");
        }

        public void ClicaBtnBusca()
        {
            ClicaElemento("/html/body/div[3]/div/div/section[1]/div/div/div[1]/div/form/div/button");
        }

        public void ValidaResultadoClass()
        {
            ValidaClass("result-text", "MXRF11");
        }

        public void ClicaResultadoBusca()
        {
            ClickElementResult("//*[@id=\'results\']/div/div[2]/div[1]/div");
        }

        public void ValidaResultadoBusca()
        {
            ValidaDados("//*[@id=\'header_action\']/div[1]/div[2]", "MXRF11");
        }
    }
}
