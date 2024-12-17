using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CachedAnimStateArray")]
	public partial class FCachedAnimStateArray : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CachedAnimStateArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCachedAnimStateArray() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCachedAnimStateArray() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCachedAnimStateArray A, FCachedAnimStateArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCachedAnimStateArray A, FCachedAnimStateArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCachedAnimStateArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FCachedAnimStateData> States
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __States, __ReturnBuffer);

					return *(TArray<FCachedAnimStateData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __States, __InBuffer);
				}
			}
		}

		private static uint __States = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}