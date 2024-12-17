using Script.CoreUObject;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceBindingReference")]
	public partial class FLevelSequenceBindingReference : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LevelSequence.LevelSequenceBindingReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelSequenceBindingReference() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelSequenceBindingReference() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelSequenceBindingReference A, FLevelSequenceBindingReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelSequenceBindingReference A, FLevelSequenceBindingReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelSequenceBindingReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoftObjectPath ExternalObjectPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExternalObjectPath, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExternalObjectPath, __InBuffer);
				}
			}
		}

		public FString ObjectPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectPath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectPath, __InBuffer);
				}
			}
		}

		private static uint __ExternalObjectPath = 0;

		private static uint __ObjectPath = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}