using NUnit.Framework;
using SiteInvestidorDez.Page;
using System.Threading;

namespace SiteInvestidorDez.Test
{
    class ValidaCotaMXRF11Test : ValidaCotaMXRF11Page
    {
        [Test]
        public void ValidaAcao()
        {
            PreencheCampoAcao();
            ClicaBtnBusca();
            ValidaResultadoClass();
            ClicaResultadoBusca();
            ValidaBuscaDividendo();
        }

        [Test]
        public void ValidaResultadoDividendo()
        {
            PreencheCampoAcao();
            ClicaBtnBusca();
            ValidaResultadoClass();
            ClicaResultadoBusca();
            ValidaResultadoAcoesEDividendos();
        }

        [Test]
        public void ValidaResultadoMultiplosDividendos()
        {
            ValidaMultiplosDividendos();
        }
    }
}
