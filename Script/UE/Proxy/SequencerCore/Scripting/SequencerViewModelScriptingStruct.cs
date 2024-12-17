using Script.CoreUObject;
using Script.Library;

namespace Script.SequencerCore
{
	[PathName("/Script/SequencerCore.SequencerViewModelScriptingStruct")]
	public partial class FSequencerViewModelScriptingStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SequencerCore.SequencerViewModelScriptingStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSequencerViewModelScriptingStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSequencerViewModelScriptingStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSequencerViewModelScriptingStruct A, FSequencerViewModelScriptingStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSequencerViewModelScriptingStruct A, FSequencerViewModelScriptingStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSequencerViewModelScriptingStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Type
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Type, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Type, __InBuffer);
				}
			}
		}

		private static uint __Type = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}