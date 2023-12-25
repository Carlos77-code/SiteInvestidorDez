using NUnit.Framework;
using SiteInvestidorDez.Page;
using System.Threading;

namespace SiteInvestidorDez.Test
{
    class ValidaAcaoTest : ValidaAcaoPage
    {
        [Test]
        public void ValidaAcao()
        {
            PreencheCampoAcao();
            ClicaBtnBusca();
            ValidaResultadoClass();
            ClicaResultadoBusca();
            ValidaResultadoBusca();
        }
    }
}
