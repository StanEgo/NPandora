
## Inbox

    todo Каким образом можно получить доступ из _app/_document к свойствам, тем или иным способом экспортируемым из конкретной страницы. Например, мета-информация или информация о BreadCrumb. 

- Рассмотреть подход, согласно которому в /pages формируется то, что можно условно назвать картой сайта. За контентом она будет обращаться в совершенно другие структуры. Так можно достичь более удачного разделения и повторного использования.

- Возможно, имеет смысл сделать MDX-плагин для обозначения переводов. Они будут добавлять lang-аттрибут к соответствующим тегам и в части рендеринга

- Есть идея реализовать все языки в одном документе. Суть заключена в том, что всякая страница может содержать language-invariant текст, а также текст, который может переводиться автоматически (скажем, использоваться формальная грамматика близкая к естественному языку). Таким образом может достигаться высокая степень реюзинга. Проблем в том, что странно работает getStaticPaths. Нельзя ему сказать, что заданная страница отвечает на /en/... и /ru/... пути.

- Brand book в стилях, язык описания brand book.

## Markup

    todo Подобрать наиболее удачную базовую разметку (main, nav, header, footer)

## Next.js

- Посмотреть примеры с использованием Redux в Next.js.
- Посмотреть примеры в поставке Next.js.
- https://github.com/unicodeveloper/awesome-nextjs, особенно интересны шаблоны и примеры.
