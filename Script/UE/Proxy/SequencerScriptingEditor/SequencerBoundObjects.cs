using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.SequencerScriptingEditor
{
	[PathName("/Script/SequencerScriptingEditor.SequencerBoundObjects")]
	public partial class FSequencerBoundObjects : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SequencerScriptingEditor.SequencerBoundObjects");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSequencerBoundObjects() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSequencerBoundObjects() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSequencerBoundObjects A, FSequencerBoundObjects B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSequencerBoundObjects A, FSequencerBoundObjects B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSequencerBoundObjects;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneBindingProxy BindingProxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BindingProxy, __ReturnBuffer);

					return *(FMovieSceneBindingProxy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BindingProxy, __InBuffer);
				}
			}
		}

		public TArray<UObject> BoundObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoundObjects, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoundObjects, __InBuffer);
				}
			}
		}

		private static uint __BindingProxy = 0;

		private static uint __BoundObjects = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}