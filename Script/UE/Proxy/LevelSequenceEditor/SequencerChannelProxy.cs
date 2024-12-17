using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.LevelSequenceEditor
{
	[PathName("/Script/LevelSequenceEditor.SequencerChannelProxy")]
	public partial class FSequencerChannelProxy : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LevelSequenceEditor.SequencerChannelProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSequencerChannelProxy() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSequencerChannelProxy() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSequencerChannelProxy A, FSequencerChannelProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSequencerChannelProxy A, FSequencerChannelProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSequencerChannelProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ChannelName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChannelName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChannelName, __InBuffer);
				}
			}
		}

		public UMovieSceneSection Section
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Section, __ReturnBuffer);

					return *(UMovieSceneSection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Section, __InBuffer);
				}
			}
		}

		private static uint __ChannelName = 0;

		private static uint __Section = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}