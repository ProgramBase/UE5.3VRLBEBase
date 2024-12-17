using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CollectionReference")]
	public partial class FCollectionReference : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CollectionReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollectionReference() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCollectionReference() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCollectionReference A, FCollectionReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollectionReference A, FCollectionReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollectionReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName CollectionName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollectionName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollectionName, __InBuffer);
				}
			}
		}

		private static uint __CollectionName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}