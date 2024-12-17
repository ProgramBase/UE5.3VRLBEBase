using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;
using Script.ControlRig;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigSequencerBindingProxy")]
	public partial class FControlRigSequencerBindingProxy : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigEditor.ControlRigSequencerBindingProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigSequencerBindingProxy() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigSequencerBindingProxy() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigSequencerBindingProxy A, FControlRigSequencerBindingProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigSequencerBindingProxy A, FControlRigSequencerBindingProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigSequencerBindingProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneBindingProxy Proxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Proxy, __ReturnBuffer);

					return *(FMovieSceneBindingProxy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Proxy, __InBuffer);
				}
			}
		}

		public UControlRig ControlRig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlRig, __ReturnBuffer);

					return *(UControlRig*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlRig, __InBuffer);
				}
			}
		}

		public UMovieSceneControlRigParameterTrack Track
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Track, __ReturnBuffer);

					return *(UMovieSceneControlRigParameterTrack*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Track, __InBuffer);
				}
			}
		}

		private static uint __Proxy = 0;

		private static uint __ControlRig = 0;

		private static uint __Track = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}