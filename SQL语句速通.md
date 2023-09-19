# SQL语句浅浅回顾

## 1、WHERE

> 类似于条件选择

| Operator（关键字）  | Condition（意思）                                            | SQL Example(例子）            |
| ------------------- | ------------------------------------------------------------ | ----------------------------- |
| =, !=, < <=, >, >=  | Standard numerical operators 基础的 大于，等于等比较         | col_name != 4                 |
| BETWEEN … AND …     | Number is within range of two values (inclusive) 在两个数之间 | col_name BETWEEN 1.5 AND 10.5 |
| NOT BETWEEN … AND … | Number is not within range of two values (inclusive) 不在两个数之间 | col_name NOT BETWEEN 1 AND 10 |
| IN (…)              | Number exists in a list 在一个列表                           | col_name IN (2, 4, 6)         |
| NOT IN (…)          | Number does not exist in a list 不在一个列表                 | col_name NOT IN (1, 3, 5)     |

### LIKE

| Operator（操作符） | Condition（解释）                                            | Example（例子）                                              |
| ------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| =                  | Case sensitive exact string comparison (*notice the single equals*)完全等于 | col_name = "abc"                                             |
| != or <>           | Case sensitive exact string inequality comparison 不等于     | col_name != "abcd"                                           |
| LIKE               | Case insensitive exact string comparison 没有用通配符等价于 = | col_name LIKE "ABC"                                          |
| NOT LIKE           | Case insensitive exact string inequality comparison 没有用通配符等价于 != | col_name NOT LIKE "ABCD"                                     |
| %                  | Used anywhere in a string to match a sequence of zero or more characters (only with LIKE or NOT LIKE) 通配符，代表匹配0个以上的字符 | col_name LIKE "%AT%" (matches "AT", "ATTIC", "CAT" or even "BATS") "%AT%" 代表AT 前后可以有任意字符 |
| _                  | Used anywhere in a string to match a single character (only with LIKE or NOT LIKE) 和% 相似，代表1个字符 | col_name LIKE "AN_" (matches "AND", but not "AN")            |
| IN (…)             | String exists in a list 在列表                               | col_name IN ("A", "B", "C")                                  |
| NOT IN (…)         | String does not exist in a list 不在列表                     | col_name NOT IN ("D", "E", "F")                              |







[自学SQL网(教程 视频 练习全套) (xuesql.cn)](http://xuesql.cn/)