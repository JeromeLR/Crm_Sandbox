using System;
using __4_DAL_CRM;
using Microsoft.Xrm.Sdk;
using TestCRM.SDK;

// ReSharper disable once CheckNamespace
namespace _4_DAL_CRM
{
    public partial class Contact
    {
        #region Civilite
        /// <summary>
        /// Civilite
        /// </summary>


        public string CiviliteLibelle
        {
            get
            {
                if (FormattedValues.Keys.Contains("familystatuscode"))
                {
                    return FormattedValues["familystatuscode"];
                }

                return string.Empty;
            }
        }

        public OptionSetValue Civilite
        {
            get
            {
                return this.GetAttributeValue<OptionSetValue>("familystatuscode");
            }
            set
            {
                this.OnPropertyChanging("familystatuscode");
                this.SetAttributeValue("familystatuscode", value);
                this.OnPropertyChanged("familystatuscode");
            }
        }
        
        #endregion
    }
}
