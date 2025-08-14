using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace OptimizelyCMSTest.Models.Pages;

[ContentType(
    DisplayName = "Another page",
    Description = "Another page, yep...",
    GUID = "f1049bf4-ad59-4fb0-97c0-df4f4e110092",
    GroupName = "My Test Pages")]
public class AnotherPage : AbstractContentPage
{
    [Display(
        Name = "HeadLine",
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual string? HeadLine { get; set; }

    [Display(
        Name = "HeadLine Slug",
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual string? HeadLineSlug { get; set; }

    [Display(
        Name = "Body",
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual XhtmlString? Body { get; set; }
}