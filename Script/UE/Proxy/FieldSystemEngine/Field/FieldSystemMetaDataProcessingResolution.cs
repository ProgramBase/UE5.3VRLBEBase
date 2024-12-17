using Script.CoreUObject;
using Script.Chaos;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution")]
	public partial class UFieldSystemMetaDataProcessingResolution : UFieldSystemMetaData, IStaticClass
	{
		public EFieldResolutionType ResolutionType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ResolutionType, __ReturnBuffer);

					return *(EFieldResolutionType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ResolutionType, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="ResolutionType">
		/// Type of processing resolution used to select the particles on which the field will be applied
		/// </param>
		public virtual UFieldSystemMetaDataProcessingResolution SetMetaDataaProcessingResolutionType(EFieldResolutionType ResolutionType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)ResolutionType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetMetaDataaProcessingResolutionType, __InBuffer, __ReturnBuffer);

				return *(UFieldSystemMetaDataProcessingResolution*)__ReturnBuffer;
			}
		}

		private static uint __ResolutionType = 0;

		private static uint __SetMetaDataaProcessingResolutionType = 0;
	}
}