using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.RegularExpressions;

namespace BaseConocimiento
{
  public partial class Form1 : Form
  {
    List<string> lTickets = new List<string>();
    List<string> lTicketsResume = new List<string>();
    List<string> lTicketsInitial = new List<string>();
    List<string> lTicketsInitialResume = new List<string>();
    enum States{STATE_DOWNLOADED, STATE_MOVED, STATE_FILTERED, STATE_UNFILTERED};
    int iCurrentTicket;
    bool resume = false;  

    public Form1()
    {
      InitializeComponent();
      downloadData();
    }

    private void downloadData()
    {
      MongoClient mongo = new MongoClient("mongodb://agallard:Diciembre2016$@ds161497.mlab.com:61497/shadow_support");
      IMongoDatabase database = mongo.GetDatabase("shadow_support");
      IMongoCollection<BsonDocument> collection = database.GetCollection<MongoDB.Bson.BsonDocument>("support");
      IAsyncCursor<BsonDocument> cursor = collection.Find(new BsonDocument()).ToCursor();

      lTickets.Clear();
      lTicketsResume.Clear();
      lTicketsInitial.Clear();
      lTicketsInitialResume.Clear();

      foreach (var document in cursor.ToEnumerable()) {
        string sTicket = title("Ticket ID:");
        string sResume = title("Ticket ID:");
        sTicket += document.GetElement("ticketid").Value + "\n\n\n";
        sResume += document.GetElement("ticketid").Value + "\n\n\n";
        sTicket += title("Problema Reportado:");
        sResume += title("Problema Reportado:");
        sTicket += document.GetElement("problemreported").Value + "\n\n\n";
        sResume += document.GetElement("problemreported").Value + "\n\n\n";
        sTicket += title("Fecha de Reporte:");
        sTicket += document.GetElement("reporteddate").Value + "\n\n\n";
        sTicket += title("Categoria:");
        sTicket += document.GetElement("category").Value + "\n\n\n";
        sTicket += title("Grupo asignado previamente:");
        sTicket += document.GetElement("previousassigmentgroup").Value + "\n\n\n";
        sTicket += title("Tipo de Solución:");
        sResume += title("Tipo de Solución:");
        sTicket += document.GetElement("typeofsolution").Value + "\n\n\n";
        sResume += document.GetElement("typeofsolution").Value + "\n\n\n";
        sTicket += title("Fecha de Resolución:");
        sTicket += document.GetElement("solveddate").Value + "\n\n\n";
        sTicket += title("Resuelto por:");
        sTicket += document.GetElement("solvedby").Value + "\n\n\n";
        sTicket += title("Pasos para resolver el Ticket:");
        sResume += title("Pasos para resolver el Ticket:");
        sTicket += document.GetElement("stepstosolveit").Value + "\n\n\n";
        sResume += document.GetElement("stepstosolveit").Value + "\n\n\n";
        sTicket += title("Promedio de horas empleadas:");
        sTicket += document.GetElement("averagehrstosolveit").Value + "\n\n\n";
        sTicket += title("Script, Query o Herramienta utilizada (Solution artifact) :");
        sResume += title("Script, Query o Herramienta utilizada (Solution artifact) :");
        sTicket += document.GetElement("scriptusedforsolution").Value + "\n\n\n";
        sResume += document.GetElement("scriptusedforsolution").Value + "\n\n\n";
        sTicket += title("¿Nos comparten el Script, Query o la Herramienta?:");
        sTicket += document.GetElement("solutionartifactshared").Value + "\n\n\n";
        sTicket += title("Otros equipos de soporte contactados:");
        sTicket += document.GetElement("othersupportteams").Value + "\n\n\n";
        sTicket += title("Recursos de Grupo BIMBO contactados:");
        sTicket += document.GetElement("resourcescontacted").Value + "\n\n\n";
        sTicket += title("¿Se requirió Escalamiento?:");
        sTicket += document.GetElement("escalationrequired").Value + "\n\n\n";
        sTicket += title("Proceso de Escalamiento aplicado:");
        sTicket += document.GetElement("escalationprocess").Value + "\n\n\n";
        sTicket += title("¿Se requirió una solicitud de cambio?:");
        sTicket += document.GetElement("changerequestneeded").Value + "\n\n\n";
        sTicket.Trim();

        lTicketsInitial.Add(sTicket);
        lTicketsInitialResume.Add(sResume);
      }

      lTickets.AddRange(lTicketsInitial);
      lTicketsResume.AddRange(lTicketsInitialResume);

      iCurrentTicket = 0;
      showTicket(iCurrentTicket);
      stateControls(States.STATE_DOWNLOADED);
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      find();
    }

    private void find()
    {
      if (txtTextFind.Text.Length > 0) {
        filter(true);
      } else {
        MessageBox.Show(this, "Introduce el texto a buscar", "Atención",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtTextFind.Focus();
      }
    }

    private void filter(Boolean bFilter)
    {
      List<string> lTicketsThatMatch = new List<string>();
      List<string> lTicketsThatMatchResume = new List<string>();

      if (bFilter) {
        foreach (string sTicket in lTicketsInitial) {
          Regex regExp = new Regex(txtTextFind.Text);
          Match match = regExp.Match(sTicket);
          if (match.Success) {
            lTicketsThatMatch.Add(sTicket);
          }
        }
        foreach (string sTicket in lTicketsInitialResume) {
          Regex regExp = new Regex(txtTextFind.Text);
          Match match = regExp.Match(sTicket);
          if (match.Success) {
            lTicketsThatMatchResume.Add(sTicket);
          }
        }        
        
        lTickets.Clear();
        lTickets.AddRange(lTicketsThatMatch);

        lTicketsResume.Clear();
        lTicketsResume.AddRange(lTicketsThatMatchResume);        
      } else {
        lTickets.Clear();
        lTickets.AddRange(lTicketsInitial);

        lTicketsResume.Clear();
        lTicketsResume.AddRange(lTicketsInitialResume);
      }

      MessageBox.Show(this, lTickets.Count + " Tickets mostrados", "Información",
          MessageBoxButtons.OK, MessageBoxIcon.Information);

      iCurrentTicket = 0;
      showTicket(iCurrentTicket);
      stateControls(States.STATE_MOVED);
    }

    private string title(string sTitle)
    {
      int size = 100;
      string sLine = " ";
      for (int i = 0; i < size; i++) {
        sLine += "-";
      }
      sLine += "\n " + sTitle + "\n";
      //for (int i = 0; i < size; i++) {
      //  sLine += "-";
      //}
      sLine += "\n";
      return sLine.TrimStart();
    }

    private void btnFirst_Click(object sender, EventArgs e)
    {
      iCurrentTicket = 0;
      showTicket(iCurrentTicket);
      stateControls(States.STATE_MOVED);
    }

    private void showTicket(int iNumTicket)
    {
      Color colorTitle;
      Color colorSearch;

      if (resume) {
        richKBase.Text = lTicketsResume.ElementAt(iNumTicket);
        colorTitle = Color.Green;
        colorSearch = Color.Gold;
      } else {
        richKBase.Text = lTickets.ElementAt(iNumTicket);
        colorTitle = Color.MediumBlue;
        colorSearch = Color.GreenYellow;
      }
      formatRich(colorTitle, colorSearch);
    }

    private void formatRich(Color colorTitle, Color colorSearch)
    {
      Regex regExp;
      regExp = new Regex(@"Ticket ID:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Problema Reportado:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Fecha de Reporte:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Categoria:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Grupo asignado previamente:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Tipo de Solución:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Fecha de Resolución:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Resuelto por:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Pasos para resolver el Ticket:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Promedio de horas empleadas:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Script, Query o Herramienta utilizada \(Solution artifact\) :");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"\¿Nos comparten el Script, Query o la Herramienta\?:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Otros equipos de soporte contactados:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Recursos de Grupo BIMBO contactados:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"\¿Se requirió Escalamiento\?:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"Proceso de Escalamiento aplicado:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));
      regExp = new Regex(@"\¿Se requirió una solicitud de cambio\?:");
      formatText(regExp, colorTitle, richKBase.BackColor, new Font(richKBase.Font, FontStyle.Bold));

      if (txtTextFind.Text.Length > 0) {
        regExp = new Regex(txtTextFind.Text);
        formatText(regExp, richKBase.ForeColor, colorSearch, new Font(richKBase.Font, FontStyle.Bold));
      } else {
        richKBase.SelectionStart = 0;
        richKBase.ScrollToCaret();
      }
    }

    private void stateControls(States state)
    {
      switch (state) {
        case States.STATE_DOWNLOADED:
          deactivateAllButtons();
          stateRecordButtons();
          break;        

        case States.STATE_MOVED:
          deactivateAllButtons();
          stateRecordButtons();
          break;

        case States.STATE_FILTERED:
          deactivateAllButtons();
          stateRecordButtons();
          btnNOFilter.Enabled = true;
          break;

        case States.STATE_UNFILTERED:
          deactivateAllButtons();
          stateRecordButtons();
          btnFilter.Enabled = true;
          break;
      }
    }

    private void deactivateAllButtons()
    {
      btnFirst.Enabled = false;
      btnPrev.Enabled = false;
      btnNext.Enabled = false;
      btnLast.Enabled = false;
    }

    private void stateRecordButtons()
    {
      if (iCurrentTicket == 0 && lTickets.Count == 0) {
        btnFirst.Enabled = false;
        btnPrev.Enabled = false;
        btnNext.Enabled = false;
        btnLast.Enabled = false;
        lblRecords.Text = " - de - registros";
      } else if (iCurrentTicket == 0 && lTickets.Count == 1) {
        btnFirst.Enabled = false;
        btnPrev.Enabled = false;
        btnNext.Enabled = false;
        btnLast.Enabled = false;
        lblRecords.Text = (iCurrentTicket + 1) + " de " + lTickets.Count + " registros";
      } else if (iCurrentTicket == 0 && lTickets.Count > 1) {
        btnNext.Enabled = true;
        btnLast.Enabled = true;
        lblRecords.Text = (iCurrentTicket + 1) + " de " + lTickets.Count + " registros";
      } else if (iCurrentTicket < (lTickets.Count - 1)) {
        btnFirst.Enabled = true;
        btnPrev.Enabled = true;
        btnNext.Enabled = true;
        btnLast.Enabled = true;
        lblRecords.Text = (iCurrentTicket + 1) + " de " + lTickets.Count + " registros";
      } else if (iCurrentTicket == (lTickets.Count - 1) && lTickets.Count != 1) {
        btnFirst.Enabled = true;
        btnPrev.Enabled = true;
        lblRecords.Text = (iCurrentTicket + 1) + " de " + lTickets.Count + " registros";
      }
    }

    private void btnPrev_Click(object sender, EventArgs e)
    {
      showTicket(--iCurrentTicket);
      stateControls(States.STATE_MOVED);
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
      showTicket(++iCurrentTicket);
      stateControls(States.STATE_MOVED);
    }

    private void btnLast_Click(object sender, EventArgs e)
    {
      iCurrentTicket = lTickets.Count - 1;
      showTicket(iCurrentTicket);
      stateControls(States.STATE_MOVED);
    }
    
    private void formatText(Regex regExp, Color color, Color colorBk, Font font)
    {
      int iFirstOcurr = 0;
      foreach (Match match in regExp.Matches(richKBase.Text)) {
        if (iFirstOcurr == 0)
          iFirstOcurr = match.Index;
        richKBase.Select(match.Index, match.Length);
        richKBase.SelectionColor = color;
        richKBase.SelectionBackColor = colorBk;
        richKBase.SelectionFont = font;
      }
      richKBase.SelectionStart = iFirstOcurr;
      richKBase.SelectionLength = 0;
      richKBase.ScrollToCaret();
    }

    private void btnNOFilter_Click(object sender, EventArgs e)
    {
      filter(false);
    }

    private void txtFind_KeyPress(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter) {
        find();
      }
    }

    private void toolStripButton1_Click_1(object sender, EventArgs e)
    {
      downloadData();
      MessageBox.Show(this, lTickets.Count + " Tickets descargados", "Información",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnResume_Click(object sender, EventArgs e)
    {
      resume = true;
      showTicket(iCurrentTicket);
    }

    private void btnComplete_Click(object sender, EventArgs e)
    {
      resume = false;
      showTicket(iCurrentTicket);
    }
  }
}
