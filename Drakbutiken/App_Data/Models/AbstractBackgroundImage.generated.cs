//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.5.96
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1077 with alias "abstractBackgroundImage"
	/// <summary>Abstract Background Image</summary>
	public partial interface IAbstractBackgroundImage : IPublishedContent
	{
		/// <summary>Image</summary>
		string Image { get; }

		/// <summary>Use Light Overlay</summary>
		bool UseLightOverlay { get; }

		/// <summary>Use Light Text Color</summary>
		bool UseLightTextColor { get; }

		/// <summary>Use Overlay</summary>
		bool UseOverlay { get; }
	}

	/// <summary>Abstract Background Image</summary>
	[PublishedContentModel("abstractBackgroundImage")]
	public partial class AbstractBackgroundImage : PublishedContentModel, IAbstractBackgroundImage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "abstractBackgroundImage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AbstractBackgroundImage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AbstractBackgroundImage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return GetImage(this); }
		}

		/// <summary>Static getter for Image</summary>
		public static string GetImage(IAbstractBackgroundImage that) { return that.GetPropertyValue<string>("image"); }

		///<summary>
		/// Use Light Overlay: If you have checked "Use Overlay" above, check this box to use a light overlay. If you leave this box unchecked, a dark overlay will be used.
		///</summary>
		[ImplementPropertyType("useLightOverlay")]
		public bool UseLightOverlay
		{
			get { return GetUseLightOverlay(this); }
		}

		/// <summary>Static getter for Use Light Overlay</summary>
		public static bool GetUseLightOverlay(IAbstractBackgroundImage that) { return that.GetPropertyValue<bool>("useLightOverlay"); }

		///<summary>
		/// Use Light Text Color: Check to use light color for text. If unchecked, dark color will be used.
		///</summary>
		[ImplementPropertyType("useLightTextColor")]
		public bool UseLightTextColor
		{
			get { return GetUseLightTextColor(this); }
		}

		/// <summary>Static getter for Use Light Text Color</summary>
		public static bool GetUseLightTextColor(IAbstractBackgroundImage that) { return that.GetPropertyValue<bool>("useLightTextColor"); }

		///<summary>
		/// Use Overlay: If you have set a background image, you can use a dark or light overlay
		///</summary>
		[ImplementPropertyType("useOverlay")]
		public bool UseOverlay
		{
			get { return GetUseOverlay(this); }
		}

		/// <summary>Static getter for Use Overlay</summary>
		public static bool GetUseOverlay(IAbstractBackgroundImage that) { return that.GetPropertyValue<bool>("useOverlay"); }
	}
}
