using Script.CoreUObject;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceBindingReferenceArray")]
	public partial class FLevelSequenceBindingReferenceArray : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LevelSequence.LevelSequenceBindingReferenceArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelSequenceBindingReferenceArray() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelSequenceBindingReferenceArray() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelSequenceBindingReferenceArray A, FLevelSequenceBindingReferenceArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelSequenceBindingReferenceArray A, FLevelSequenceBindingReferenceArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelSequenceBindingReferenceArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FLevelSequenceBindingReference> References
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __References, __ReturnBuffer);

					return *(TArray<FLevelSequenceBindingReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __References, __InBuffer);
				}
			}
		}

		private static uint __References = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}