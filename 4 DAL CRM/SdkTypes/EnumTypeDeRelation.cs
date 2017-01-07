using System.ComponentModel;

namespace __4_DAL_CRM
{
    public enum EnumTypeDeRelation
    {
        [Description("Client")]
        Clients = 100000000,

        [Description("Partenaire")]
        Partenaires = 100000001,

        [Description("Prospect")]
        Prospects = 100000002,

        [Description("Fournisseur")]
        Fournisseurs = 100000003,

        [Description("Sous-traitant")]
        SousTraitant = 100000004,

        /*Concurrent
        Client/Fournisseur
        Particulier
        Autre
        Ami(e)
        Organisme état/ind
        Entreprise Adaptée
        Association
        Prescripteur
        Partenaire*/

    }
}