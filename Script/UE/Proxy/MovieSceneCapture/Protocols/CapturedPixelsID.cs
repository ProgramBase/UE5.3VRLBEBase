using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.CapturedPixelsID")]
	public partial class FCapturedPixelsID : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneCapture.CapturedPixelsID");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCapturedPixelsID() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCapturedPixelsID() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCapturedPixelsID A, FCapturedPixelsID B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCapturedPixelsID A, FCapturedPixelsID B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCapturedPixelsID;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FName, FName> Identifiers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Identifiers, __ReturnBuffer);

					return *(TMap<FName, FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Identifiers, __InBuffer);
				}
			}
		}

		private static uint __Identifiers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}