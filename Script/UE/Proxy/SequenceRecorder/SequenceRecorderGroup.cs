using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.SequenceRecorder
{
	[PathName("/Script/SequenceRecorder.SequenceRecorderGroup")]
	public partial class ASequenceRecorderGroup : AActor, IStaticClass
	{
		public TArray<USequenceRecorderActorGroup> ActorGroups
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActorGroups, __ReturnBuffer);

					return *(TArray<USequenceRecorderActorGroup>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActorGroups, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequenceRecorder.SequenceRecorderGroup");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ActorGroups = 0;
	}
}