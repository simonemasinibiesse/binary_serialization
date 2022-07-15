using BinarySerializationProblem.Exceptions;
using System;
using System.Collections.ObjectModel;

namespace BinarySerializationProblem.ParameterEdit
{
    [Serializable]
    public class CustomObservableCollection<T> : ObservableCollection<T>
    {
        public Func<bool> _isReadOnly;
        
        public Func<bool> IsReadOnly
        {
            get { return _isReadOnly; }
            set { _isReadOnly = value; }
        }

        private bool isReadOnly
        {
            get
            {
                if (IsReadOnly != null)
                    return IsReadOnly();
                
                return false;
            }
        }

        public new void Add(T item)
        {
            if (isReadOnly)
                throw new ReadOnlyElementException();

            base.Add(item);
        }

        public new void Clear()
        {
            if (isReadOnly)
                throw new ReadOnlyElementException();

            base.Clear();
        }

        public new void Insert(int index, T item)
        {
            if (isReadOnly)
                throw new ReadOnlyElementException();

            base.Insert(index, item);
        }

        public new void Move(int oldIndex, int newIndex)
        {
            if (isReadOnly)
                throw new ReadOnlyElementException();

            base.Move(oldIndex, newIndex);
        }

        public new bool Remove(T item)
        {
            if (isReadOnly)
                throw new ReadOnlyElementException();

            return base.Remove(item);
        }

        public new void RemoveAt(int index)
        {
            if (isReadOnly)
                throw new ReadOnlyElementException();

            base.RemoveAt(index);
        }
    }
}
