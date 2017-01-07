using System.ComponentModel;

namespace TestCRM.SDK
{
    public enum EnumStatutJuridique
    {
        [Description("Entreprise individuelle")]
        EI = 100000000,

        [Description("Entreprise individuelle à responsabilité limitée (EIRL)")]
        EIRL = 100000001,

        [Description("Entreprise unipersonnelle à responsabilité limitée (EURL)")]
        EURL = 100000002,

        [Description("Société en nom collectif (SNC)")]
        SNC = 100000003,

        [Description("Société anonyme (SA)")]
        SA = 100000004,

        [Description("Société à responsabilité limitée (SARL)")]
        SARL = 100000005,

        [Description("Société d'exercice libéral à responsabilité limitée (SELARL)")]
        SELARL = 100000006,

        [Description("Société civile professionnelle (SCP)")]
        SCP = 100000007,

        [Description("Société par actions simplifiée (SAS)")]
        SAS = 100000008,

        [Description("Société par actions simplifiée unipersonnelle (SASU)")]
        SASU = 100000009,

        //Après ajout manuel dans l'administration CRM
        
        [Description("Association Loi 1901")]
        Asso = 100000010,

        
        [Description("Collectivité Locale")]
        CollectiviteLocale = 100000011,

        
        [Description("Organisation Gouvernementale")]
        OrganisationGouvernementale = 100000012,

        
        [Description("Inconnu")]
        Inconnu = 100000013


    }
}
