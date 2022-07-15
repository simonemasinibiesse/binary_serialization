#define TwinTypes

using BinarySerializationProblem.Exceptions;
using System;
using System.Runtime.Serialization;

namespace BinarySerializationProblem.ParameterEdit
{
    [Serializable]
    public class ToolParameterEdit : ParameterEdit, IDisposable
    {
        public ToolParameterEdit()
        {
            Initialize();
        }

        public ToolParameterEdit(ToolParameterEdit src)
            : base(src)
        {
            Initialize();

            // Non voglio che si sollevino degli eventi di modificato.
            Classes.CollectionChanged -= CustomObservableCollection_CollectionChanged;
            if (src.Classes != null)
                foreach (var item in src.Classes)
                    Classes.Add(item);
            Classes.CollectionChanged += CustomObservableCollection_CollectionChanged;

            SubClasses.CollectionChanged -= CustomObservableCollection_CollectionChanged;
            if (src.SubClasses != null)
                foreach (var item in src.SubClasses)
                    SubClasses.Add(item);
            SubClasses.CollectionChanged += CustomObservableCollection_CollectionChanged;

            Rotations.CollectionChanged -= CustomObservableCollection_CollectionChanged;
            if (src.Rotations != null)
                foreach (var item in src.Rotations)
                    Rotations.Add(item);
            Rotations.CollectionChanged += CustomObservableCollection_CollectionChanged;

#if TwinTypes
            TwinTypes.CollectionChanged -= CustomObservableCollection_CollectionChanged;
            if (src.TwinTypes != null)
                foreach (var item in src.TwinTypes)
                    TwinTypes.Add(item);
            TwinTypes.CollectionChanged += CustomObservableCollection_CollectionChanged;
#endif

            _couplingType = src._couplingType;
            _allowEmpty = src._allowEmpty;
            _editorMode = src._editorMode;
        }

        public CustomObservableCollection<ToolClasses> Classes { get; set; }

        public CustomObservableCollection<ToolSubClasses> SubClasses { get; set; }

        public CustomObservableCollection<ToolRotDirections> Rotations { get; set; }

#if TwinTypes
        [field: OptionalField]
        public CustomObservableCollection<ToolTwinTypes> TwinTypes { get; set; }
#endif

        private int? _couplingType;
        public int? CouplingType
        {
            get => _couplingType;
            set
            {
                if (IsReadOnly)
                    throw new ReadOnlyElementException();

                if (_couplingType != value)
                {
                    _couplingType = value;
                    //OnModified();
                }
            }
        }

        private bool _allowEmpty;
        public bool AllowEmpty
        {
            get => _allowEmpty;
            set
            {
                if (IsReadOnly)
                    throw new ReadOnlyElementException();

                if (_allowEmpty != value)
                {
                    _allowEmpty = value;
                    //OnModified();
                }
            }
        }

        private ParameterChooseEditorMode _editorMode;
        public ParameterChooseEditorMode EditorMode
        {
            get => _editorMode;
            set
            {
                if (IsReadOnly)
                    throw new ReadOnlyElementException();

                if (_editorMode != value)
                {
                    _editorMode = value;
                    //OnModified();
                }
            }
        }

        private void Initialize()
        {
            Classes = new CustomObservableCollection<ToolClasses>
            {
                IsReadOnly = () => this.IsReadOnly
            };
            Classes.CollectionChanged += CustomObservableCollection_CollectionChanged;

            SubClasses = new CustomObservableCollection<ToolSubClasses>
            {
                IsReadOnly = () => this.IsReadOnly
            };
            SubClasses.CollectionChanged += CustomObservableCollection_CollectionChanged;

            Rotations = new CustomObservableCollection<ToolRotDirections>
            {
                IsReadOnly = () => this.IsReadOnly
            };
            Rotations.CollectionChanged += CustomObservableCollection_CollectionChanged;

#if TwinTypes
            TwinTypes = new CustomObservableCollection<ToolTwinTypes>
            {
                IsReadOnly = MyIsReadOnly
            };
            TwinTypes.CollectionChanged += CustomObservableCollection_CollectionChanged;
#endif

            _couplingType = null;
            _allowEmpty = false;
            _editorMode = ParameterChooseEditorMode.Combo;
        }

        private void CustomObservableCollection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //OnModified();
        }

        private bool MyIsReadOnly()
        {
            return this.IsReadOnly;
        }

        protected override bool IsTypeAdmissible()
        {
            return true;
        }

        public override ParameterTypes ParameterType => ParameterTypes.Tool;

        public override string Args
        {
            get
            {
                return "blablabla";
            }
        }

        public override object Clone()
        {
            return new ToolParameterEdit(this);
        }

        public void Dispose()
        {
            Classes.CollectionChanged -= CustomObservableCollection_CollectionChanged;
            SubClasses.CollectionChanged -= CustomObservableCollection_CollectionChanged;
            Rotations.CollectionChanged -= CustomObservableCollection_CollectionChanged;
#if TwinTypes
            TwinTypes.CollectionChanged -= CustomObservableCollection_CollectionChanged;
#endif
        }
    }
}
