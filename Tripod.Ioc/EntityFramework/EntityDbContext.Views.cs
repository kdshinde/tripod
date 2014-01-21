//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(Tripod.Ioc.EntityFramework.EntityDbContext),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySetsbcdc4fe7a9bee5311e1f0909847026410f308ddd497e0b61b3e36f38b395c560))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework Power Tools", "0.9.0.0")]
    internal sealed class ViewsForBaseEntitySetsbcdc4fe7a9bee5311e1f0909847026410f308ddd497e0b61b3e36f38b395c560 : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "bcdc4fe7a9bee5311e1f0909847026410f308ddd497e0b61b3e36f38b395c560"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "CodeFirstDatabase.ExceptionAudit")
            {
                return GetView0();
            }

            if (extentName == "EntityDbContext.ExceptionAudits")
            {
                return GetView1();
            }

            if (extentName == "CodeFirstDatabase.User")
            {
                return GetView2();
            }

            if (extentName == "CodeFirstDatabase.Claim")
            {
                return GetView3();
            }

            if (extentName == "CodeFirstDatabase.EmailAddress")
            {
                return GetView4();
            }

            if (extentName == "CodeFirstDatabase.LocalMembership")
            {
                return GetView5();
            }

            if (extentName == "CodeFirstDatabase.Permission")
            {
                return GetView6();
            }

            if (extentName == "CodeFirstDatabase.RemoteMembership")
            {
                return GetView7();
            }

            if (extentName == "CodeFirstDatabase.EmailConfirmation")
            {
                return GetView8();
            }

            if (extentName == "CodeFirstDatabase.EmailMessage")
            {
                return GetView9();
            }

            if (extentName == "CodeFirstDatabase.UserPermission")
            {
                return GetView10();
            }

            if (extentName == "EntityDbContext.Users")
            {
                return GetView11();
            }

            if (extentName == "EntityDbContext.Claims")
            {
                return GetView12();
            }

            if (extentName == "EntityDbContext.EmailAddresses")
            {
                return GetView13();
            }

            if (extentName == "EntityDbContext.LocalMemberships")
            {
                return GetView14();
            }

            if (extentName == "EntityDbContext.Permissions")
            {
                return GetView15();
            }

            if (extentName == "EntityDbContext.RemoteMemberships")
            {
                return GetView16();
            }

            if (extentName == "EntityDbContext.EmailConfirmations")
            {
                return GetView17();
            }

            if (extentName == "EntityDbContext.EmailMessages")
            {
                return GetView18();
            }

            if (extentName == "EntityDbContext.User_Permissions")
            {
                return GetView19();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.ExceptionAudit.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing ExceptionAudit
        [CodeFirstDatabaseSchema.ExceptionAudit](T1.ExceptionAudit_ErrorId, T1.ExceptionAudit_Application, T1.ExceptionAudit_Host, T1.ExceptionAudit_Type, T1.ExceptionAudit_Source, T1.ExceptionAudit_Message, T1.ExceptionAudit_User, T1.ExceptionAudit_StatusCode, T1.ExceptionAudit_TimeUtc, T1.ExceptionAudit_Sequence, T1.ExceptionAudit_AllXml)
    FROM (
        SELECT 
            T.Id AS ExceptionAudit_ErrorId, 
            T.Application AS ExceptionAudit_Application, 
            T.Host AS ExceptionAudit_Host, 
            T.Type AS ExceptionAudit_Type, 
            T.Source AS ExceptionAudit_Source, 
            T.Message AS ExceptionAudit_Message, 
            T.User AS ExceptionAudit_User, 
            T.StatusCode AS ExceptionAudit_StatusCode, 
            T.OnUtc AS ExceptionAudit_TimeUtc, 
            T.Sequence AS ExceptionAudit_Sequence, 
            T.Xml AS ExceptionAudit_AllXml, 
            True AS _from0
        FROM EntityDbContext.ExceptionAudits AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for EntityDbContext.ExceptionAudits.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing ExceptionAudits
        [Tripod.Ioc.EntityFramework.ExceptionAudit](T1.ExceptionAudit_Id, T1.ExceptionAudit_Application, T1.ExceptionAudit_Host, T1.ExceptionAudit_Type, T1.ExceptionAudit_Source, T1.ExceptionAudit_Message, T1.ExceptionAudit_User, T1.ExceptionAudit_StatusCode, T1.ExceptionAudit_OnUtc, T1.ExceptionAudit_Sequence, T1.ExceptionAudit_Xml)
    FROM (
        SELECT 
            T.ErrorId AS ExceptionAudit_Id, 
            T.Application AS ExceptionAudit_Application, 
            T.Host AS ExceptionAudit_Host, 
            T.Type AS ExceptionAudit_Type, 
            T.Source AS ExceptionAudit_Source, 
            T.Message AS ExceptionAudit_Message, 
            T.User AS ExceptionAudit_User, 
            T.StatusCode AS ExceptionAudit_StatusCode, 
            T.TimeUtc AS ExceptionAudit_OnUtc, 
            T.Sequence AS ExceptionAudit_Sequence, 
            T.AllXml AS ExceptionAudit_Xml, 
            True AS _from0
        FROM CodeFirstDatabase.ExceptionAudit AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.User.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing User
        [CodeFirstDatabaseSchema.User](T1.User_Id, T1.User_Name, T1.User_SecurityStamp)
    FROM (
        SELECT 
            T.Id AS User_Id, 
            T.Name AS User_Name, 
            T.SecurityStamp AS User_SecurityStamp, 
            True AS _from0
        FROM EntityDbContext.Users AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Claim.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Claim
        [CodeFirstDatabaseSchema.Claim](T1.Claim_Id, T1.Claim_UserId, T1.Claim_ClaimType, T1.Claim_ClaimValue)
    FROM (
        SELECT 
            T.Id AS Claim_Id, 
            T.UserId AS Claim_UserId, 
            T.ClaimType AS Claim_ClaimType, 
            T.ClaimValue AS Claim_ClaimValue, 
            True AS _from0
        FROM EntityDbContext.Claims AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.EmailAddress.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing EmailAddress
        [CodeFirstDatabaseSchema.EmailAddress](T1.EmailAddress_Id, T1.EmailAddress_OwnerId, T1.EmailAddress_Value, T1.EmailAddress_IsDefault, T1.EmailAddress_IsConfirmed)
    FROM (
        SELECT 
            T.Id AS EmailAddress_Id, 
            T.OwnerId AS EmailAddress_OwnerId, 
            T.[Value] AS EmailAddress_Value, 
            T.IsDefault AS EmailAddress_IsDefault, 
            T.IsConfirmed AS EmailAddress_IsConfirmed, 
            True AS _from0
        FROM EntityDbContext.EmailAddresses AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.LocalMembership.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing LocalMembership
        [CodeFirstDatabaseSchema.LocalMembership](T1.LocalMembership_UserId, T1.LocalMembership_PasswordHash, T1.LocalMembership_IsConfirmed)
    FROM (
        SELECT 
            T.Id AS LocalMembership_UserId, 
            T.PasswordHash AS LocalMembership_PasswordHash, 
            T.IsConfirmed AS LocalMembership_IsConfirmed, 
            True AS _from0
        FROM EntityDbContext.LocalMemberships AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Permission.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView6()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Permission
        [CodeFirstDatabaseSchema.Permission](T1.Permission_Id, T1.Permission_Name, T1.Permission_Description)
    FROM (
        SELECT 
            T.Id AS Permission_Id, 
            T.Name AS Permission_Name, 
            T.Description AS Permission_Description, 
            True AS _from0
        FROM EntityDbContext.Permissions AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.RemoteMembership.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView7()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing RemoteMembership
        [CodeFirstDatabaseSchema.RemoteMembership](T1.RemoteMembership_LoginProvider, T1.RemoteMembership_ProviderKey, T1.RemoteMembership_UserId)
    FROM (
        SELECT 
            T.LoginProvider AS RemoteMembership_LoginProvider, 
            T.ProviderKey AS RemoteMembership_ProviderKey, 
            T.UserId AS RemoteMembership_UserId, 
            True AS _from0
        FROM EntityDbContext.RemoteMemberships AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.EmailConfirmation.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView8()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing EmailConfirmation
        [CodeFirstDatabaseSchema.EmailConfirmation](T1.EmailConfirmation_Id, T1.EmailConfirmation_OwnerId, T1.EmailConfirmation_Token, T1.EmailConfirmation_Ticket, T1.EmailConfirmation_Secret, T1.EmailConfirmation_ExpiresOnUtc, T1.EmailConfirmation_RedeemedOnUtc, T1.EmailConfirmation_Purpose)
    FROM (
        SELECT 
            T.Id AS EmailConfirmation_Id, 
            T.OwnerId AS EmailConfirmation_OwnerId, 
            T.Token AS EmailConfirmation_Token, 
            T.Ticket AS EmailConfirmation_Ticket, 
            T.Secret AS EmailConfirmation_Secret, 
            T.ExpiresOnUtc AS EmailConfirmation_ExpiresOnUtc, 
            T.RedeemedOnUtc AS EmailConfirmation_RedeemedOnUtc, 
            CAST(T.Purpose AS [Edm.Int32]) AS EmailConfirmation_Purpose, 
            True AS _from0
        FROM EntityDbContext.EmailConfirmations AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.EmailMessage.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView9()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing EmailMessage
        [CodeFirstDatabaseSchema.EmailMessage](T1.EmailMessage_Id, T1.EmailMessage_OwnerId, T1.EmailMessage_From, T1.EmailMessage_Subject, T1.EmailMessage_Body, T1.EmailMessage_IsBodyHtml, T1.EmailMessage_SendOnUtc, T1.EmailMessage_SentOnUtc, T1.EmailMessage_CancelledOnUtc, T1.EmailMessage_LastSendError)
    FROM (
        SELECT 
            T.Id AS EmailMessage_Id, 
            T.OwnerId AS EmailMessage_OwnerId, 
            T.[From] AS EmailMessage_From, 
            T.Subject AS EmailMessage_Subject, 
            T.Body AS EmailMessage_Body, 
            T.IsBodyHtml AS EmailMessage_IsBodyHtml, 
            T.SendOnUtc AS EmailMessage_SendOnUtc, 
            T.SentOnUtc AS EmailMessage_SentOnUtc, 
            T.CancelledOnUtc AS EmailMessage_CancelledOnUtc, 
            T.LastSendError AS EmailMessage_LastSendError, 
            True AS _from0
        FROM EntityDbContext.EmailMessages AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.UserPermission.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView10()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing UserPermission
        [CodeFirstDatabaseSchema.UserPermission](T1.UserPermission_UserId, T1.UserPermission_PermissionId)
    FROM (
        SELECT 
            Key(T.User_Permissions_Source).Id AS UserPermission_UserId, 
            Key(T.User_Permissions_Target).Id AS UserPermission_PermissionId, 
            True AS _from0
        FROM EntityDbContext.User_Permissions AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for EntityDbContext.Users.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView11()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Users
        [Tripod.Ioc.EntityFramework.User](T1.User_Id, T1.User_Name, T1.User_SecurityStamp)
    FROM (
        SELECT 
            T.Id AS User_Id, 
            T.Name AS User_Name, 
            T.SecurityStamp AS User_SecurityStamp, 
            True AS _from0
        FROM CodeFirstDatabase.User AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for EntityDbContext.Claims.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView12()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Claims
        [Tripod.Ioc.EntityFramework.Claim](T1.Claim_Id, T1.Claim_UserId, T1.Claim_ClaimType, T1.Claim_ClaimValue)
    FROM (
        SELECT 
            T.Id AS Claim_Id, 
            T.UserId AS Claim_UserId, 
            T.ClaimType AS Claim_ClaimType, 
            T.ClaimValue AS Claim_ClaimValue, 
            True AS _from0
        FROM CodeFirstDatabase.Claim AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for EntityDbContext.EmailAddresses.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView13()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing EmailAddresses
        [Tripod.Ioc.EntityFramework.EmailAddress](T1.EmailAddress_Id, T1.EmailAddress_OwnerId, T1.EmailAddress_Value, T1.EmailAddress_IsDefault, T1.EmailAddress_IsConfirmed)
    FROM (
        SELECT 
            T.Id AS EmailAddress_Id, 
            T.OwnerId AS EmailAddress_OwnerId, 
            T.[Value] AS EmailAddress_Value, 
            T.IsDefault AS EmailAddress_IsDefault, 
            T.IsConfirmed AS EmailAddress_IsConfirmed, 
            True AS _from0
        FROM CodeFirstDatabase.EmailAddress AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for EntityDbContext.LocalMemberships.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView14()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing LocalMemberships
        [Tripod.Ioc.EntityFramework.LocalMembership](T1.LocalMembership_Id, T1.LocalMembership_PasswordHash, T1.LocalMembership_IsConfirmed)
    FROM (
        SELECT 
            T.UserId AS LocalMembership_Id, 
            T.PasswordHash AS LocalMembership_PasswordHash, 
            T.IsConfirmed AS LocalMembership_IsConfirmed, 
            True AS _from0
        FROM CodeFirstDatabase.LocalMembership AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for EntityDbContext.Permissions.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView15()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Permissions
        [Tripod.Ioc.EntityFramework.Permission](T1.Permission_Id, T1.Permission_Name, T1.Permission_Description)
    FROM (
        SELECT 
            T.Id AS Permission_Id, 
            T.Name AS Permission_Name, 
            T.Description AS Permission_Description, 
            True AS _from0
        FROM CodeFirstDatabase.Permission AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for EntityDbContext.RemoteMemberships.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView16()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing RemoteMemberships
        [Tripod.Ioc.EntityFramework.RemoteMembership](T1.RemoteMembership_LoginProvider, T1.RemoteMembership_ProviderKey, T1.RemoteMembership_UserId)
    FROM (
        SELECT 
            T.LoginProvider AS RemoteMembership_LoginProvider, 
            T.ProviderKey AS RemoteMembership_ProviderKey, 
            T.UserId AS RemoteMembership_UserId, 
            True AS _from0
        FROM CodeFirstDatabase.RemoteMembership AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for EntityDbContext.EmailConfirmations.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView17()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing EmailConfirmations
        [Tripod.Ioc.EntityFramework.EmailConfirmation](T1.EmailConfirmation_Id, T1.EmailConfirmation_OwnerId, T1.EmailConfirmation_Token, T1.EmailConfirmation_Ticket, T1.EmailConfirmation_Secret, T1.EmailConfirmation_ExpiresOnUtc, T1.EmailConfirmation_RedeemedOnUtc, T1.EmailConfirmation_Purpose)
    FROM (
        SELECT 
            T.Id AS EmailConfirmation_Id, 
            T.OwnerId AS EmailConfirmation_OwnerId, 
            T.Token AS EmailConfirmation_Token, 
            T.Ticket AS EmailConfirmation_Ticket, 
            T.Secret AS EmailConfirmation_Secret, 
            T.ExpiresOnUtc AS EmailConfirmation_ExpiresOnUtc, 
            T.RedeemedOnUtc AS EmailConfirmation_RedeemedOnUtc, 
            CAST(T.Purpose AS [Tripod.Ioc.EntityFramework.EmailConfirmationPurpose]) AS EmailConfirmation_Purpose, 
            True AS _from0
        FROM CodeFirstDatabase.EmailConfirmation AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for EntityDbContext.EmailMessages.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView18()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing EmailMessages
        [Tripod.Ioc.EntityFramework.EmailMessage](T1.EmailMessage_Id, T1.EmailMessage_OwnerId, T1.EmailMessage_From, T1.EmailMessage_Subject, T1.EmailMessage_Body, T1.EmailMessage_IsBodyHtml, T1.EmailMessage_SendOnUtc, T1.EmailMessage_SentOnUtc, T1.EmailMessage_CancelledOnUtc, T1.EmailMessage_LastSendError)
    FROM (
        SELECT 
            T.Id AS EmailMessage_Id, 
            T.OwnerId AS EmailMessage_OwnerId, 
            T.[From] AS EmailMessage_From, 
            T.Subject AS EmailMessage_Subject, 
            T.Body AS EmailMessage_Body, 
            T.IsBodyHtml AS EmailMessage_IsBodyHtml, 
            T.SendOnUtc AS EmailMessage_SendOnUtc, 
            T.SentOnUtc AS EmailMessage_SentOnUtc, 
            T.CancelledOnUtc AS EmailMessage_CancelledOnUtc, 
            T.LastSendError AS EmailMessage_LastSendError, 
            True AS _from0
        FROM CodeFirstDatabase.EmailMessage AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for EntityDbContext.User_Permissions.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView19()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing User_Permissions
        [Tripod.Ioc.EntityFramework.User_Permissions](T3.[User_Permissions.User_Permissions_Source], T3.[User_Permissions.User_Permissions_Target])
    FROM (
        SELECT -- Constructing User_Permissions_Source
            CreateRef(EntityDbContext.Users, row(T2.[User_Permissions.User_Permissions_Source.Id]), [Tripod.Ioc.EntityFramework.User]) AS [User_Permissions.User_Permissions_Source], 
            T2.[User_Permissions.User_Permissions_Target]
        FROM (
            SELECT -- Constructing User_Permissions_Target
                T1.[User_Permissions.User_Permissions_Source.Id], 
                CreateRef(EntityDbContext.Permissions, row(T1.[User_Permissions.User_Permissions_Target.Id]), [Tripod.Ioc.EntityFramework.Permission]) AS [User_Permissions.User_Permissions_Target]
            FROM (
                SELECT 
                    T.UserId AS [User_Permissions.User_Permissions_Source.Id], 
                    T.PermissionId AS [User_Permissions.User_Permissions_Target.Id], 
                    True AS _from0
                FROM CodeFirstDatabase.UserPermission AS T
            ) AS T1
        ) AS T2
    ) AS T3");
        }
    }
}
