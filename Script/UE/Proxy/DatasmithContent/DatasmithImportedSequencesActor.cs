using Script.CoreUObject;
using Script.Engine;
using Script.LevelSequence;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithImportedSequencesActor")]
	public partial class ADatasmithImportedSequencesActor : AActor, IStaticClass
	{
		public TArray<ULevelSequence> ImportedSequences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ImportedSequences, __ReturnBuffer);

					return *(TArray<ULevelSequence>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ImportedSequences, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithImportedSequencesActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void PlayLevelSequence(ULevelSequence SequenceToPlay)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SequenceToPlay?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PlayLevelSequence, __InBuffer);
			}
		}

		private static uint __ImportedSequences = 0;

		private static uint __PlayLevelSequence = 0;
	}
}