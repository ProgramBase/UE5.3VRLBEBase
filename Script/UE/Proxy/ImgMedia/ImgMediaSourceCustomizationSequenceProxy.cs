using Script.CoreUObject;
using Script.Library;

namespace Script.ImgMedia
{
	[PathName("/Script/ImgMedia.ImgMediaSourceCustomizationSequenceProxy")]
	public partial class FImgMediaSourceCustomizationSequenceProxy : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ImgMedia.ImgMediaSourceCustomizationSequenceProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FImgMediaSourceCustomizationSequenceProxy() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FImgMediaSourceCustomizationSequenceProxy() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FImgMediaSourceCustomizationSequenceProxy A, FImgMediaSourceCustomizationSequenceProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FImgMediaSourceCustomizationSequenceProxy A, FImgMediaSourceCustomizationSequenceProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FImgMediaSourceCustomizationSequenceProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}