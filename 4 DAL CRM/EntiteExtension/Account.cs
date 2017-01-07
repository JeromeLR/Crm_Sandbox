using System;
using __4_DAL_CRM;
using Microsoft.Xrm.Sdk;
using TestCRM.SDK;

// ReSharper disable once CheckNamespace
namespace _4_DAL_CRM
{
    public partial class Account
    {
        #region Statut Juridique
        /// <summary>
        /// Type de Relation
        /// </summary>


        public string StatutJuridiqueLibelle
        {
            get
            {
                if (FormattedValues.Keys.Contains("new_statut_juridique"))
                {
                    return FormattedValues["new_statut_juridique"];
                }

                return string.Empty;
            }
        }

        public OptionSetValue StatutJuridique
        {
            get
            {
                return this.GetAttributeValue<OptionSetValue>("new_statut_juridique");
            }
            set
            {
                this.OnPropertyChanging("new_statut_juridique");
                this.SetAttributeValue("new_statut_juridique", value);
                this.OnPropertyChanged("new_statut_juridique");
            }
        }

        //public EnumStatutJuridique StatutJuridiqueEnum
        //{
        //    get
        //    {
        //        return (EnumStatutJuridique)GetAttributeValue<OptionSetValue>("new_statut_juridique").Value;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("new_statut_juridique");
        //        this.SetAttributeValue("new_statut_juridique", new OptionSetValue((int)value));
        //        this.OnPropertyChanged("new_statut_juridique");
        //    }
        //}
        #endregion

        #region Type de Relation
        /// <summary>
        /// Type de Relation
        /// </summary>
        public string TypeDeRelationLibelle
        {
            //get { return FormattedValues["new_type_de_relation"]; }
            get
            {
                if (FormattedValues.Keys.Contains("new_type_de_relation"))
                {
                    return FormattedValues["new_type_de_relation"];
                }

                return String.Empty;
            }
        }

        public OptionSetValue TypeDeRelation
        {
            get
            {
                return this.GetAttributeValue<OptionSetValue>("new_type_de_relation");
            }
            set
            {
                this.OnPropertyChanging("new_type_de_relation");
                this.SetAttributeValue("new_type_de_relation", value);
                this.OnPropertyChanged("new_type_de_relation");
            }
        }

        //public EnumTypeDeRelation TypeDeRelationEnum
        //{
        //    get
        //    {
        //        return (EnumTypeDeRelation)GetAttributeValue<OptionSetValue>("new_type_de_relation").Value;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("new_type_de_relation");
        //        this.SetAttributeValue("new_type_de_relation", new OptionSetValue((int)value));
        //        this.OnPropertyChanged("new_type_de_relation");
        //    }
        //}
        #endregion

        #region ConditionsReglement
        /// <summary>
        /// ConditionsReglement
        /// </summary>


        public string ConditionsReglementLibelle
        {
            get
            {
                if (FormattedValues.Keys.Contains("paymenttermscode"))
                {
                    return FormattedValues["paymenttermscode"];
                }

                return string.Empty;
            }
        }

        public OptionSetValue ConditionsReglement
        {
            get
            {
                return this.GetAttributeValue<OptionSetValue>("paymenttermscode");
            }
            set
            {
                this.OnPropertyChanging("paymenttermscode");
                this.SetAttributeValue("paymenttermscode", value);
                this.OnPropertyChanged("paymenttermscode");
            }
        }

        //public EnumConditionsReglement ConditionsReglementEnum
        //{
        //    get
        //    {
        //        return (EnumConditionsReglement)GetAttributeValue<OptionSetValue>("paymenttermscode").Value;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("paymenttermscode");
        //        this.SetAttributeValue("paymenttermscode", new OptionSetValue((int)value));
        //        this.OnPropertyChanged("paymenttermscode");
        //    }
        //}
        #endregion

        #region Secteur d'activité
        public string IndustryCodeLibelle
        {
            get
            {
                if (FormattedValues.Keys.Contains("industrycode"))
                {
                    return FormattedValues["industrycode"];
                }

                return String.Empty;
            }
        }
        #endregion
        
        #region CA
        public string chiffreAffaireConsommeAnnuel
        {
            get { return FormattedValues["new_chiffre_daffaire_consomme_annuel"]; }
        }

        public string ChiffreAffaireConsommeTotal
        {
            get { return FormattedValues["new_chiffre_daffaire_consomme_total"]; }
        }

        public string ChiffreAffaireFactureAnnuel
        {
            get { return FormattedValues["revenue_base"]; }
        }
        #endregion

        #region TVA intracommunautaire
        public string TvaIntracommunautaire
        {
            get
            {
                return Attributes["new_tva_intracommunautaire"].ToString();
            }
            set
            {
                this.OnPropertyChanging("new_tva_intracommunautaire");
                this.SetAttributeValue("new_tva_intracommunautaire", value);
                this.OnPropertyChanged("new_tva_intracommunautaire");
            }
        }
        #endregion

        #region Service
        public string Service
        {
            get { return Attributes["department"].ToString(); }
        }
        #endregion
    }
}