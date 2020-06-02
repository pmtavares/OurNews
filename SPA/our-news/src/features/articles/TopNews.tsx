import React, {useEffect, useState} from 'react'
import { Grid, Image, Card, Icon } from 'semantic-ui-react'
import  './TopNews.style.css';
import { IArticle } from '../../app/models/article';
import agent from '../../app/api/agent';
import moment from 'moment'

const TopNews = () => {
    const [articles, setArticles] = useState<IArticle[]>([]);
    useEffect(() => {
  
        agent.Articles.listLatest().then(response => {
          setArticles(response)
        });
    
        return () => {
          
        }
      }, [])
    return (
        <Grid>
            <Grid.Row columns={3}>
                {
                    articles.length > 0 &&
                    articles.map((data) => (
                        <Grid.Column key={data.id}>                 
                        <Card style={{width: "100%", overflowWrap: 'break-word'}}>
                                <Image src={data.mainPhoto} className="card-image" href="#" fluid/>
                                <Card.Content>
                                <Card.Header style={{color: "#4a4949"}}>
                                    {data.title}
                                </Card.Header>
                                <Card.Description style={{minHeight: "5.5em"}}>
                                    {data.description}
                                </Card.Description>
                                </Card.Content>
                                <Card.Content extra>
                                    <Icon name='user' />{data.author}                  
                                    <Icon name='clock' style={{marginLeft: "10%"}}/>
                                    {moment(data.datePublished).format("DD MMM YYYY")}
                                    
                                </Card.Content>
                        </Card>                                  
                    </Grid.Column>

                    ))
                }
            </Grid.Row>
      </Grid>
    )
}



export default TopNews
