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
	/// <summary>Percentages Section</summary>
	[PublishedContentModel("sectionPercentages")]
	public partial class SectionPercentages : PublishedContentModel, IAbstractSectionEffects
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sectionPercentages";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SectionPercentages(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SectionPercentages, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide Title
		///</summary>
		[ImplementPropertyType("hideTitle")]
		public bool HideTitle
		{
			get { return this.GetPropertyValue<bool>("hideTitle"); }
		}

		///<summary>
		/// Animation Direction: Choose the direction from which the animation will start. If you leave this selection empty and animations are enabled, the section will just "fade" in place.
		///</summary>
		[ImplementPropertyType("animationDirection")]
		public object AnimationDirection
		{
			get { return AbstractSectionEffects.GetAnimationDirection(this); }
		}

		///<summary>
		/// Enable Animation: Check this box to make this section animate. You can then specify the exact kind of animation using the options below.
		///</summary>
		[ImplementPropertyType("animationEnable")]
		public bool AnimationEnable
		{
			get { return AbstractSectionEffects.GetAnimationEnable(this); }
		}

		///<summary>
		/// Larger Animation: Check this to amplify the animation effect
		///</summary>
		[ImplementPropertyType("animationLarger")]
		public bool AnimationLarger
		{
			get { return AbstractSectionEffects.GetAnimationLarger(this); }
		}
	}
}
