using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.UserGeneratedContentLocalizationDescriptor")]
	public partial class FUserGeneratedContentLocalizationDescriptor : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.UserGeneratedContentLocalizationDescriptor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUserGeneratedContentLocalizationDescriptor() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FUserGeneratedContentLocalizationDescriptor() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FUserGeneratedContentLocalizationDescriptor A, FUserGeneratedContentLocalizationDescriptor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUserGeneratedContentLocalizationDescriptor A, FUserGeneratedContentLocalizationDescriptor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUserGeneratedContentLocalizationDescriptor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString NativeCulture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NativeCulture, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NativeCulture, __InBuffer);
				}
			}
		}

		public TArray<FString> CulturesToGenerate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CulturesToGenerate, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CulturesToGenerate, __InBuffer);
				}
			}
		}

		public EPortableObjectFormat PoFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PoFormat, __ReturnBuffer);

					return *(EPortableObjectFormat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PoFormat, __InBuffer);
				}
			}
		}

		private static uint __NativeCulture = 0;

		private static uint __CulturesToGenerate = 0;

		private static uint __PoFormat = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}