<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ArticleLayout.ascx.cs"
    Inherits="GiaPhuc.Controls.ArticleLayout" %>
<style type="text/css">
    #articles
    {
        position: relative;
        margin: 0 0 15px 0;
    }
    .articles
    {
        width: 930px !important;
        margin-left: 30px;
        overflow: hidden;
    }
    .articles .item
    {
        border-left: 1px solid #ddd;
        width: 310px !important;
        overflow: hidden;
        white-space: normal;
    }
    .articles .item .desc
    {
        padding-top: 15px;
        margin-right: 4px;
        font-family: Times New Roman;
    }
    .articles .item .desc a
    {
        text-decoration: none;
    }
    .articles .item .desc:hover a
    {
        text-decoration: underline;
    }
    .articles .item .img img
    {
        float: left;
        clear: right;
        margin: 6px;
        height: 80px;
    }
    
    .center .nav
    {
        position: absolute;
        top: 0;
    }
    .center #prev.nav
    {
        margin-top: 40px;
        border-width: 7px 11px 7px 0;
        border-color: transparent #ccc transparent transparent;
        border-style: inset inset inset solid;
        left: 10px;
    }
    .center #prev.nav .arrow-conceal
    {
        border-width: 5.5px 2.75px 5.5px 0;
        border-color: transparent #fff transparent transparent;
        border-style: inset inset inset solid;
        right: -11px;
        position: absolute;
        top: -5.5px;
        display: block;
        width: 0;
        height: 0;
    }
    .center #next.nav
    {
        margin-top: 75px;
        border-width: 7px 0 7px 11px;
        border-color: transparent transparent transparent #ccc;
        border-style: inset inset inset solid;
        left: 10px;
    }
    .center #next.nav .arrow-conceal
    {
        border-width: 5.5px 0 5.5px 2.75px;
        border-color: transparent transparent transparent #fff;
        border-style: inset inset inset solid;
        left: -11px;
        position: absolute;
        top: -5.5px;
        display: block;
        width: 0;
        height: 0;
    }
    .center #prev.nav:hover
    {
        background-position: 0 -25px;
    }
    .center #next.nav:hover
    {
        background-position: -34px -25px;
    }
    .coffee-title 
    {
        overflow: hidden;
        margin: 0 10px 5px 10px;
        border-bottom: 1px solid #ddd;
        position: relative;
    }
    .coffee-title .tit
    {
        float: left;
        overflow: hidden;
    }
    .coffee-title #pager 
    {
        float: right;
    }
</style>
