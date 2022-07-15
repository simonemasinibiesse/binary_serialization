using System;

namespace BinarySerializationProblem.ParameterEdit
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParameterTypes
    {
        /// <summary>
        /// </summary>
        Simple = 0,
        /// <summary>
        /// </summary>
        SingleInteger = 1,
        /// <summary>
        /// </summary>
        CouplingType = 2,
        /// <summary>
        /// </summary>
        MultiInteger = 3,
        /// <summary>
        /// </summary>
        File = 4,
        /// <summary>
        /// </summary>
        Choice = 5,
        /// <summary>
        /// </summary>
        [Obsolete("v. 2.2.0.142")]
        ArticleChoice = 6,
        /// <summary>
        /// </summary>
        ToolTech = 7,
        /// <summary>
        /// </summary>
        Formula = 8,
        /// <summary>
        /// </summary>
        Enum = 9,
        /// <summary>
        /// </summary>
        Aggregate = 10,
        /// <summary>
        /// </summary>
        Tool = 11,
        /// <summary>
        /// </summary>
        Accessory = 12,
        /// <summary>
        /// </summary>
        MachineEquipping = 13,
        /// <summary>
        /// </summary>
        SingleString = 14,
        /// <summary>
        /// </summary>
        MultiDouble = 15,
        /// <summary>
        /// </summary>
        MultiString = 16,
        /// <summary>
        /// </summary>
        SingleDouble = 17,
        /// <summary>
        /// </summary>
        Folder = 18,
        /// <summary>
        /// </summary>
        DoubleValues = 19,
        /// <summary>
        /// </summary>
        IntegerValues = 20,
        /// <summary>
        /// </summary>
        ComboboxEditable = 28,
        /// <summary>
        /// </summary>
        BitsInteger = 29,
        /// <summary>
        /// </summary>
        Border = 30,
        /// <summary>
        /// </summary>
        Insertion = 31,
        /// <summary>
        /// </summary>
        DateTime = 32,
        /// <summary>
        /// </summary>
        Mill = 33,
        /// <summary>
        /// </summary>
        Date = 34,
        /// <summary>
        /// </summary>
        TimeOfDay = 35,
        /// <summary>
        /// </summary>
        Glue = 36,
        /// <summary>
        /// </summary>
        Profile = 37,
        /// <summary>
        /// </summary>
        Material = 38
    }
}
