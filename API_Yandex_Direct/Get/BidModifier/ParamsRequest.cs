﻿using API_Yandex_Direct.Get.Shared;
using System;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.BidModifier
{
    [DataContract]
    public class ParamsRequest : ParamsRequestAbstract
    {
        public ParamsRequest(FieldNamesEnum[] enumsFieldNames) : base(enumsFieldNames as Array) { }
        /// <summary>
        /// Критерий отбора групп.
        /// </summary>
        [DataMember]
        public BidModifiersSelectionCriteria SelectionCriteria { get; set; }        
    }
}
