using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany.Service.Dtos
{
    public class PageResultDto<TDto>
    {
        public PageResultDto(int totalRecord, IEnumerable<TDto> items)
        {
            TotalRecord = totalRecord;
            Items = items;
        }

        public PageResultDto(int totalRecord, int totalPage, IEnumerable<TDto> items)
        {
            TotalRecord = totalRecord;
            TotalPage = totalPage;
            Items = items;
        }

        public int TotalRecord { get; set; }

        public int TotalPage { get; set; }

        public IEnumerable<TDto> Items { get; set; }
    }
}
