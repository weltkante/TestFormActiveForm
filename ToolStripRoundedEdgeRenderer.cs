namespace TestFormActiveForm
{
    using System.Windows.Forms;

    public class ToolStripRoundedEdgeRenderer : ToolStripProfessionalRenderer
    {
        public ToolStripRoundedEdgeRenderer()
        {
            this.RoundedEdges = false;
        }

        public ToolStripRoundedEdgeRenderer(ProfessionalColorTable professionalColorTable)
            : base(professionalColorTable)
        {
            this.RoundedEdges = false;
        }
    }
}
