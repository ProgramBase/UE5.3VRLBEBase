using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraPlatformSetRedirect")]
	public partial class FNiagaraPlatformSetRedirect : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraPlatformSetRedirect");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraPlatformSetRedirect() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraPlatformSetRedirect() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraPlatformSetRedirect A, FNiagaraPlatformSetRedirect B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraPlatformSetRedirect A, FNiagaraPlatformSetRedirect B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraPlatformSetRedirect;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> ProfileNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProfileNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProfileNames, __InBuffer);
				}
			}
		}

		public ENiagaraDeviceProfileRedirectMode Mode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Mode, __ReturnBuffer);

					return *(ENiagaraDeviceProfileRedirectMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Mode, __InBuffer);
				}
			}
		}

		public FName RedirectProfileName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RedirectProfileName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RedirectProfileName, __InBuffer);
				}
			}
		}

		public FNiagaraPlatformSetCVarCondition CVarConditionEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CVarConditionEnabled, __ReturnBuffer);

					return *(FNiagaraPlatformSetCVarCondition*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CVarConditionEnabled, __InBuffer);
				}
			}
		}

		public FNiagaraPlatformSetCVarCondition CVarConditionDisabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CVarConditionDisabled, __ReturnBuffer);

					return *(FNiagaraPlatformSetCVarCondition*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CVarConditionDisabled, __InBuffer);
				}
			}
		}

		private static uint __ProfileNames = 0;

		private static uint __Mode = 0;

		private static uint __RedirectProfileName = 0;

		private static uint __CVarConditionEnabled = 0;

		private static uint __CVarConditionDisabled = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}