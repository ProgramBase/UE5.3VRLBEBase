using Script.CoreUObject;
using Script.Chaos;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldSystemMetaDataFilter")]
	public partial class UFieldSystemMetaDataFilter : UFieldSystemMetaData, IStaticClass
	{
		public EFieldFilterType FilterType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilterType, __ReturnBuffer);

					return *(EFieldFilterType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilterType, __InBuffer);
				}
			}
		}

		public EFieldObjectType ObjectType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectType, __ReturnBuffer);

					return *(EFieldObjectType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectType, __InBuffer);
				}
			}
		}

		public EFieldPositionType PositionType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PositionType, __ReturnBuffer);

					return *(EFieldPositionType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PositionType, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.FieldSystemMetaDataFilter");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="FilterType">
		/// State type used to select the state particles on which the field will be applied
		/// </param>
		/// <param name="ObjectType">
		/// Object type used to select the type of objects(rigid, cloth...) on which the field will be applied
		/// </param>
		/// <param name="PositionType">
		/// Position type used to compute the samples positions
		/// </param>
		public virtual UFieldSystemMetaDataFilter SetMetaDataFilterType(EFieldFilterType FilterType, EFieldObjectType ObjectType, EFieldPositionType PositionType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[3];

				*(byte*)(__InBuffer) = (byte)FilterType;

				*(byte*)(__InBuffer + 1) = (byte)ObjectType;

				*(byte*)(__InBuffer + 2) = (byte)PositionType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetMetaDataFilterType, __InBuffer, __ReturnBuffer);

				return *(UFieldSystemMetaDataFilter*)__ReturnBuffer;
			}
		}

		private static uint __FilterType = 0;

		private static uint __ObjectType = 0;

		private static uint __PositionType = 0;

		private static uint __SetMetaDataFilterType = 0;
	}
}