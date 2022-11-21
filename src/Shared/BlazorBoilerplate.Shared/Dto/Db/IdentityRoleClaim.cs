using Breeze.Sharp;

namespace BlazorBoilerplate.Shared.Dto.Db
{
    public partial class IdentityRoleClaim : BaseEntity
    {

        public Int32 Id
        {
            get { return GetValue<Int32>(); }
            set { SetValue(value); }
        }

        public String ClaimType
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String ClaimValue
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public Guid RoleId
        {
            get { return GetValue<Guid>(); }
            set { SetValue(value); }
        }

        public String TenantId
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

    }
}
