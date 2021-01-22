// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Request parameters for creating a new work or school account user. </summary>
    public partial class UserCreateParameters : UserBase
    {
        /// <summary> Initializes a new instance of UserCreateParameters. </summary>
        /// <param name="accountEnabled"> Whether the account is enabled. </param>
        /// <param name="displayName"> The display name of the user. </param>
        /// <param name="passwordProfile"> Password Profile. </param>
        /// <param name="userPrincipalName"> The user principal name (someuser@contoso.com). It must contain one of the verified domains for the tenant. </param>
        /// <param name="mailNickname"> The mail alias for the user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/>, <paramref name="passwordProfile"/>, <paramref name="userPrincipalName"/>, or <paramref name="mailNickname"/> is null. </exception>
        public UserCreateParameters(bool accountEnabled, string displayName, PasswordProfile passwordProfile, string userPrincipalName, string mailNickname)
        {
            if (displayName == null)
            {
                throw new ArgumentNullException(nameof(displayName));
            }
            if (passwordProfile == null)
            {
                throw new ArgumentNullException(nameof(passwordProfile));
            }
            if (userPrincipalName == null)
            {
                throw new ArgumentNullException(nameof(userPrincipalName));
            }
            if (mailNickname == null)
            {
                throw new ArgumentNullException(nameof(mailNickname));
            }

            AccountEnabled = accountEnabled;
            DisplayName = displayName;
            PasswordProfile = passwordProfile;
            UserPrincipalName = userPrincipalName;
            MailNickname = mailNickname;
        }

        /// <summary> Whether the account is enabled. </summary>
        public bool AccountEnabled { get; }
        /// <summary> The display name of the user. </summary>
        public string DisplayName { get; }
        /// <summary> Password Profile. </summary>
        public PasswordProfile PasswordProfile { get; }
        /// <summary> The user principal name (someuser@contoso.com). It must contain one of the verified domains for the tenant. </summary>
        public string UserPrincipalName { get; }
        /// <summary> The mail alias for the user. </summary>
        public string MailNickname { get; }
        /// <summary> The primary email address of the user. </summary>
        public string Mail { get; set; }
    }
}