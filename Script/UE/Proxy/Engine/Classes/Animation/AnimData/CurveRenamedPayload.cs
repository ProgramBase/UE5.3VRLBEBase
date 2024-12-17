using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CurveRenamedPayload")]
	public partial class FCurveRenamedPayload : FCurvePayload, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CurveRenamedPayload");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCurveRenamedPayload()
		{
		}

		public static bool operator ==(FCurveRenamedPayload A, FCurveRenamedPayload B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCurveRenamedPayload A, FCurveRenamedPayload B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCurveRenamedPayload;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FAnimationCurveIdentifier NewIdentifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewIdentifier, __ReturnBuffer);

					return *(FAnimationCurveIdentifier*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewIdentifier, __InBuffer);
				}
			}
		}

		private static uint __NewIdentifier = 0;

	}
}