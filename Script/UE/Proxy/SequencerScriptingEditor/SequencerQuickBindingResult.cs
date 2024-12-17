using Script.CoreUObject;
using Script.Library;
using Script.BlueprintGraph;

namespace Script.SequencerScriptingEditor
{
	[PathName("/Script/SequencerScriptingEditor.SequencerQuickBindingResult")]
	public partial class FSequencerQuickBindingResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SequencerScriptingEditor.SequencerQuickBindingResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSequencerQuickBindingResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSequencerQuickBindingResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSequencerQuickBindingResult A, FSequencerQuickBindingResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSequencerQuickBindingResult A, FSequencerQuickBindingResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSequencerQuickBindingResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UK2Node_CustomEvent EventEndpoint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EventEndpoint, __ReturnBuffer);

					return *(UK2Node_CustomEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EventEndpoint, __InBuffer);
				}
			}
		}

		public TArray<FString> PayloadNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PayloadNames, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PayloadNames, __InBuffer);
				}
			}
		}

		private static uint __EventEndpoint = 0;

		private static uint __PayloadNames = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}