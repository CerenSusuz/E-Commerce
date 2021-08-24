﻿using Core.Signatures;

namespace DataAccess.Entities
{
    public class AccountAddress : BaseEntity
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public AddressType AccountAddressType { get; set; }
    }
}