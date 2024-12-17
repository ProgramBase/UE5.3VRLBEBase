using Script.CoreUObject;
using Script.Library;

namespace Script.InputCore
{
	[PathName("/Script/InputCore.Key")]
	public partial class FKey : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InputCore.Key");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FKey() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FKey() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FKey A, FKey B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FKey A, FKey B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FKey;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName KeyName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyName, __InBuffer);
				}
			}
		}

		private static uint __KeyName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}