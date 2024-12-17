using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DialogueWaveParameter")]
	public partial class FDialogueWaveParameter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DialogueWaveParameter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDialogueWaveParameter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDialogueWaveParameter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDialogueWaveParameter A, FDialogueWaveParameter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDialogueWaveParameter A, FDialogueWaveParameter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDialogueWaveParameter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UDialogueWave DialogueWave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DialogueWave, __ReturnBuffer);

					return *(UDialogueWave*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DialogueWave, __InBuffer);
				}
			}
		}

		public FDialogueContext Context
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Context, __ReturnBuffer);

					return *(FDialogueContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Context, __InBuffer);
				}
			}
		}

		private static uint __DialogueWave = 0;

		private static uint __Context = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}