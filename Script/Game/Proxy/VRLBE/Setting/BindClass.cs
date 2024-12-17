using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealCSharpCore
{
	[PathName("/Script/UnrealCSharpCore.BindClass")]
	public partial class FBindClass : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealCSharpCore.BindClass");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBindClass() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBindClass() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBindClass A, FBindClass B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBindClass A, FBindClass B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBindClass;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UObject> Class
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Class, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Class, __InBuffer);
				}
			}
		}

		public bool bNeedMonoClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNeedMonoClass, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNeedMonoClass, __InBuffer);
				}
			}
		}

		private static uint __Class = 0;

		private static uint __bNeedMonoClass = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}