﻿namespace GF.UCenter.Common.Portable.Models.AppClient
{
    using System.Runtime.Serialization;

    [DataContract]
    public class AccountUploadProfileImageResponse : AccountRequestResponse
    {
        public override void ApplyEntity(AccountResponse account)
        {
            base.ApplyEntity(account);
        }
    }
}