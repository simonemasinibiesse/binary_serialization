using BinarySerializationProblem.ParameterEdit;
using System;
using System.IO;
using System.Windows.Forms;

namespace BinarySerializationProblem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSerialize_Click(object sender, EventArgs e)
        {
            ToolParameterEdit toolParameterEdit = new ToolParameterEdit();

            toolParameterEdit.Classes.Add(ToolClasses.Mill);
            toolParameterEdit.Classes.Add(ToolClasses.Blade);

            toolParameterEdit.SubClasses.Add(ToolSubClasses.CounterSinkDiskCutterMill);
            toolParameterEdit.SubClasses.Add(ToolSubClasses.DoubleDiameterFlatDrillBit);
            toolParameterEdit.SubClasses.Add(ToolSubClasses.BigFlatDrillBit);

            toolParameterEdit.Rotations.Add(ToolRotDirections.Bidirectional);

            toolParameterEdit.EditorMode = ParameterChooseEditorMode.OpenDialog;

            toolParameterEdit.AllowEmpty = true;
            toolParameterEdit.IsCustomized = true;

            byte[] bytes = Misc.SerializeToByteArray(toolParameterEdit);

            using (var fileStream = new FileStream(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "file.dat"), FileMode.OpenOrCreate, FileAccess.Write))
            {
                fileStream.Write(bytes, 0, bytes.Length);
            }
        }

        private void BtnDeserialize_Click(object sender, EventArgs e)
        {
            byte[] bytes;
            using (var fileStream = new FileStream(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "file.dat"), FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[fileStream.Length];
                int num = fileStream.Read(bytes, 0, bytes.Length);
            }

            ToolParameterEdit toolParameterEdit = Misc.DeserializeFromByteArray<ToolParameterEdit>(bytes);

            MessageBox.Show("Done");
        }
    }
}
