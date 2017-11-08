using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMGenkARMPText
{
    public partial class ARMPTextGenerator : Form
    {
        public ARMPTextGenerator()
        {
            InitializeComponent();
        }

        private void btnSORA_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("SORA methodologie:\n\nS methodologie:\nOmschrijving:\nFoutmelding:\nAlarmen/beelden:\nTijdstip:\nCoilgegevens:\nLocatie:\nWaarneming:\nMelder:\nFrequentie:\nVoorafgaande gebeurtenissen:\nExtra info:\n\nO methodologie:\nIdee oorzaak:\n\nR methodologie:\nAnalyse:\nActies:\n\nA methodologie:\nHerstelling:\nStilstand ?:\n");
        }
        private void btnS_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("S methodologie:\n\nOmschrijving:\nFoutmelding:\nAlarmen/beelden:\nTijdstip:\nCoilgegevens:\nLocatie:\nWaarneming:\nMelder:\nFrequentie:\nVoorafgaande gebeurtenissen:\nExtra info:\n");
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("O methodologie:\n\nIdee oorzaak:\n");
        }
        private void btnR_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("R methodologie:\n\nAnalyse:\nActies:\n");
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("A methodologie:\n\nHerstelling:\nStilstand?:\n");
        }
        private void btnAandachtspunten_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("AANDACHTSPUNTEN:\n\nAlgemeen: Controle en aanpassing schema's, tekeningen, P&ID\n\nAlgemeen: ARMP\n\nAlgemeen: Opleiding/communicatie\n\nUitbating: WVS'en\n\nUitbating: Setpoints en instellingen\n\nUitbating: Specifiek (lijnlengtes, rolwissel, BS5, SIAS)\n\nOnderhoud: Preventief\n\nOnderhoud: Onderhoudbaarheid\n\nVeiligheid: IBN steekkaarten\n\nVeiligheid: Vergrendelde stop\n\nVeiligheid: Risicoanalyse\n\nLegaal: Keuringen\n\nLegaal: Attestering/registrering\n");
        }
    }
}
