using Script.CoreUObject;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.CustomizedToolMenuNameArray")]
	public partial class FCustomizedToolMenuNameArray : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Slate.CustomizedToolMenuNameArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCustomizedToolMenuNameArray() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCustomizedToolMenuNameArray() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCustomizedToolMenuNameArray A, FCustomizedToolMenuNameArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCustomizedToolMenuNameArray A, FCustomizedToolMenuNameArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCustomizedToolMenuNameArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> Names
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Names, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Names, __InBuffer);
				}
			}
		}

		private static uint __Names = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}