using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialParameterCollection")]
	public partial class UMaterialParameterCollection : UObject, IStaticClass
	{
		public FGuid StateId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StateId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StateId, __InBuffer);
				}
			}
		}

		public TArray<FCollectionScalarParameter> ScalarParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScalarParameters, __ReturnBuffer);

					return *(TArray<FCollectionScalarParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScalarParameters, __InBuffer);
				}
			}
		}

		public TArray<FCollectionVectorParameter> VectorParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VectorParameters, __ReturnBuffer);

					return *(TArray<FCollectionVectorParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VectorParameters, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialParameterCollection");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TArray<FName> GetVectorParameterNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetVectorParameterNames, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <param name="ParameterName">
		/// - The name of the value to get the value of
		/// </param>
		/// <param name="bParameterFound">
		/// - if a parameter with the input name was found
		/// </param>
		/// <returns>
		/// the value of the parameter
		/// </returns>
		public virtual FLinearColor GetVectorParameterDefaultValue(FName ParameterName, ref bool bParameterFound)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bParameterFound;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __GetVectorParameterDefaultValue, __InBuffer, __OutBuffer, __ReturnBuffer);

				bParameterFound = *(bool*)(__OutBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetScalarParameterNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetScalarParameterNames, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <param name="ParameterName">
		/// - The name of the value to get the value of
		/// </param>
		/// <param name="bParameterFound">
		/// - if a parameter with the input name was found
		/// </param>
		/// <returns>
		/// the value of the parameter
		/// </returns>
		public virtual float GetScalarParameterDefaultValue(FName ParameterName, ref bool bParameterFound)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bParameterFound;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetScalarParameterDefaultValue, __InBuffer, __OutBuffer, __ReturnBuffer);

				bParameterFound = *(bool*)(__OutBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __StateId = 0;

		private static uint __ScalarParameters = 0;

		private static uint __VectorParameters = 0;

		private static uint __GetVectorParameterNames = 0;

		private static uint __GetVectorParameterDefaultValue = 0;

		private static uint __GetScalarParameterNames = 0;

		private static uint __GetScalarParameterDefaultValue = 0;
	}
}